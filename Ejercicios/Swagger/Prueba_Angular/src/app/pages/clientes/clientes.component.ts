import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { Component, EventEmitter, OnInit } from '@angular/core';
import { map } from 'rxjs';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})

export class ClientesComponent implements OnInit {
  private _baseUrl = 'https://localhost:7152';

  personas:PersonMiniDTO[] = [];
  constructor(
    public httpClient: HttpClient,
  ) {}

  async ngOnInit(){
    await this.getPersonas();
  }

  async getPersonas() {
    return await this.httpClient.get(`${this._baseUrl}/Person/GetListPerson`).pipe(
      map((response: any) => {
        console.log(response);
        const asObject: PersonMiniDTO [] = response;
        this.personas = asObject;
        return asObject;
      })
    ).toPromise();
  } 

  
}

export interface PersonMiniDTO{
    id: string,
    name: string,
    surname1:string,
    surname2:string,
    age:string
}
