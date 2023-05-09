import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { map } from 'rxjs';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit{
  private _baseUrl = 'https://localhost:7152';

  clientId: string = '';
  clientExist: boolean = false;
  clientPost: ClientePostDTO = {
    id: '',
    userName: '',
    saldo: 0,
    personId:'',
  }

  client: ClienteMiniDTO = {
    id: '',
    userName: '',
    saldo: 0,
    personId:'',
    name:'',
    surname1:'',
    surname2:'',
    age:'',
  };

  constructor(
    private readonly router : Router,
    private readonly route : ActivatedRoute,
    public httpClient: HttpClient,
  ){

  }

  ngOnInit(): void {
    this.route.params.subscribe(async params => {
      const paramValue = params['id'];
      console.log(paramValue);

      if(paramValue !== '' || paramValue !== null){
        this.clientId = paramValue;
        this.clientExist = true;
        await this.getDataClient(paramValue);
      }
    });
  }

  async getDataClient(clientid: string){
    console.log(clientid);
    await this.httpClient.post(`${this._baseUrl}/Customer/GetCustomerById/${clientid}`, {Id: clientid}).pipe(
      map((response: any) => {
        console.log(response);
        this.client = response;
      })
    ).toPromise();
  }

  async saveDataClient(){
    await this.httpClient.post(`${this._baseUrl}/Customer/AddEditCustomer`, 
    {
      Id: this.client.id,
      UserName: this.client.userName,
      Saldo: this.client.saldo,
      PersonId: this.client.personId
    }).pipe(
      map((response: any) => {
        console.log(response);
        this.client = response;
      })
    ).toPromise();
  }

  goBack(){
    this.router.navigate(['cliente']);
  }

  //#region onChange
  onChangeUserName(value: any){
    console.log(value);
    this.client.userName = value;
  }

  onChangeSaldo(value: any){
    console.log(value);
    this.client.saldo = value;
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
}

export interface ClientePostDTO{
  id: string,
  userName: string,
  saldo: number,
  personId: string,
}
