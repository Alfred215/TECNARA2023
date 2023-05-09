import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent {
  private _baseUrl = 'https://localhost:7152';

  clientes:ClienteMiniDTO[] = [];
  constructor(
    private httpClient: HttpClient,
    private readonly router: Router,
  ) {}

  async ngOnInit(){
    await this.getDataListCliente();
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

  goToDetailsClient(id: string){
    this.router.navigate(['cliente/details',id])
  }

  async deleteClient(id: string){
    await this.httpClient.delete(`${this._baseUrl}/Customer/DeleteCustomerById/${id}`).pipe(
      map((response: any) => {
        return response;
      })
    ).toPromise();

    await this.getDataListCliente();
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
