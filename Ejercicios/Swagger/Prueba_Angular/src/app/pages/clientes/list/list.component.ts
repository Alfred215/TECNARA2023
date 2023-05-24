import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
  
export class ListComponent implements OnInit {
  private _baseUrl = 'https://localhost:7152';

  collectionClientes: CollectionClienteDTO = {
    pageIndex:0,
    pageSize:0,
    personas:[]
  }

  filterCustomer:FilterCustomer={
    userName:null,
    saldo: null,
    estado: null,
    orderBy: null,
    ascOrDesc: null
  } 

  estadosPersona: EstadosPersona[] = [
    {id: null, description: 'Todos'},
    {id: EstadoType.Casado, description: 'Casado'},
    {id: EstadoType.Divorciado, description: 'Divorciado'},
    {id: EstadoType.Soltero, description: 'Soltero'},
  ]

  public filtroUserName: string = '';
  public filtroSaldo: number | undefined;
  filters: boolean = false;

  constructor(
    private httpClient: HttpClient,
    private readonly router: Router,
    private toastrService: ToastrService
  ) {}
  
  async ngOnInit(){
    await this.getDataListFilterCliente();
  }

//#region GET TABLE
  async getDataListFilterCliente() {
    let filter = '';
    if(this.collectionClientes.pageIndex > 0 && this.collectionClientes.pageSize > 0){
      filter = `?pageIndex=${this.collectionClientes.pageIndex}&pageSize=${this.collectionClientes.pageSize}`;
    }

    this.filterCustomer.userName = this.filterCustomer.userName == '' || null ? null : this.filterCustomer.userName;
    this.filterCustomer.saldo = this.filterCustomer.saldo?.toString() == '' ? null : this.filterCustomer.saldo;
    this.filterCustomer.estado = this.filterCustomer.estado?.toString() !== '' && this.filterCustomer.estado != null ? Number(this.filterCustomer.estado) : null;

    return await this.httpClient.post(`${this._baseUrl}/Customer/GetListFilterCustomer${filter}`,this.filterCustomer).pipe(
      map((response: any) => {
        const asObject: CollectionClienteDTO = response;
        this.collectionClientes = asObject;
        return asObject;
      })
  ).toPromise();
  } 
//#endregion

//#region Method TABLE
  async deleteClient(id: string){
    await this.httpClient.delete(`${this._baseUrl}/Customer/DeleteCustomerById/${id}`).pipe(
      map((response: any) => {
        return response;
      })
    ).toPromise();
    this.showSuccess();
    await this.getDataListFilterCliente();
  }

  goToCreateClient() {
    this.router.navigate(['cliente/new'])
  }

  goToDetailsClient(id: string){
    this.router.navigate(['cliente/details',id])
  }

  changePage(num: number){
    this.collectionClientes.pageIndex += num;

    if(this.collectionClientes.pageIndex < 1){
      this.collectionClientes.pageIndex = 1;
    }

    this.getDataListFilterCliente();
  }

  setOrderByColumn(column: string){
    if(column !== this.filterCustomer.orderBy){
      this.filterCustomer.orderBy = column;
      this.filterCustomer.ascOrDesc = true;
    }else{
      if(this.filterCustomer.ascOrDesc){
        this.filterCustomer.ascOrDesc = false;
      }else{
        this.filterCustomer.ascOrDesc = null;
        this.filterCustomer.orderBy = null;
      }
    }

    this.getDataListFilterCliente();
  }
//#endregion

//#region TOAST
  public showSuccess(): void {
    this.toastrService.success('Cliente borrado correctamente!', 'Borrado');
  }

  public showTest(): void {
    this.toastrService.success('Esto es un toast configurable', '¡Hola!', {
      timeOut: 3000, // Cerrar automáticamente después de 3 segundos
      progressBar: true // Mostrar la barra de progreso
    });

    this.toastrService.warning('Esto es como de aviso', '¡Cuidao!', {
      positionClass: 'toast-top-left' // Mostrar en la esquina superior izquierda
    });

    this.toastrService.error('Esto es como de error', '¡ojito!');

    this.toastrService.info('Esto es asi como que bueno si quieres lo lees y si no no');
  }
//#endregion

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
  estado: EstadoType
  estadoDescription: string
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

export interface EstadosPersona{
  id: EstadoType | null,
  description: string
}

export enum EstadoType {
  Casado,
  Soltero,
  Divorciado,
}

export interface FilterCustomer{
  userName: string | null,
  saldo: number | null,
  estado: EstadoType | null,
  orderBy: string | null,
  ascOrDesc: boolean | null
}
