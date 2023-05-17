import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  private _baseUrl = 'https://localhost:7152';

  clientes: ClienteMiniDTO[] = [];

  collectionClientes: CollectionClienteDTO = {
    pageIndex:0,
    pageSize:0,
    personas:[]
  }
  public filtroUserName: string = '';
  public filtroSaldo: number | undefined;

  constructor(
    private httpClient: HttpClient,
    private readonly router: Router,
    ) {}
    
  async ngOnInit(){
    await this.getDataListFilterCliente();
  }
  
  ngAfterViewInit() {
    const searchInput = document.getElementById('datatable-search-input');
    searchInput?.addEventListener('input', this.searchTable.bind(this));
  }

  async getDataListCliente() {
      return await this.httpClient.get(`${this._baseUrl}/Customer/GetListCustomer`).pipe(
        map((response: any) => {
          console.log(response);
          const asObject: ClienteMiniDTO [] = response;
          this.clientes = asObject;
          return asObject;
        })
    ).toPromise();
  } 

  async getDataListFilterCliente() {
    let filter = '';
    if(this.collectionClientes.pageIndex > 0 && this.collectionClientes.pageSize > 0){
      filter = `?pageIndex=${this.collectionClientes.pageIndex}&pageSize=${this.collectionClientes.pageSize}`;
    }
    return await this.httpClient.get(`${this._baseUrl}/Customer/GetListFilterCustomer${filter}`).pipe(
      map((response: any) => {
        const asObject: CollectionClienteDTO = response;
        this.collectionClientes = asObject;
        return asObject;
      })
  ).toPromise();
} 

  searchTable(event: Event) {
    const searchText = (event.target as HTMLInputElement).value.toLowerCase();
    const rows = Array.from(document.querySelectorAll('#datatable-row')) as HTMLTableRowElement[];

    rows.forEach((row) => {
      const userName = row?.querySelector('td:nth-child(2)')?.textContent?.toLowerCase();
      if (userName?.includes(searchText)) {
        row.style.display = ''; // Mostrar la fila si coincide con la búsqueda
      } else {
        row.style.display = 'none'; // Ocultar la fila si no coincide con la búsqueda
      }
    });
  }

  async deleteClient(id: string){
    await this.httpClient.delete(`${this._baseUrl}/Customer/DeleteCustomerById/${id}`).pipe(
      map((response: any) => {
        return response;
      })
    ).toPromise();

    await this.getDataListCliente();
  }

  goToDetailsClient(id: string){
    this.router.navigate(['cliente/details',id])
  }

  goToCreateClient() {
    this.router.navigate(['cliente/new'])
  }

  changePage(num: number){
    this.collectionClientes.pageIndex += num;

    if(this.collectionClientes.pageIndex < 1){
      this.collectionClientes.pageIndex = 1;
    }

    this.getDataListFilterCliente();
  }
}

export interface ClienteMiniDTO{
  id: string,
  userName: string,
  saldo: number,
  personId: string,
  name: string,
  surname1:string,
  surname2:string,
  age:string
}

export interface PersonMiniDTO{
    id: string,
    name: string,
    surname1:string,
    surname2:string,
    age:string
}

export interface CollectionClienteDTO{
  pageIndex: number,
  pageSize: number,
  personas: ClienteMiniDTO[]
}
