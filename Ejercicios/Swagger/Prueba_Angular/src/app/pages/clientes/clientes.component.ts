import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { Component, EventEmitter, OnInit } from '@angular/core';
import { map } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})

export class ClientesComponent implements OnInit {
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
    this.router.navigate(['details',id])
  }

  async deleteClient(id: string){

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
