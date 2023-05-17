import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { map } from 'rxjs';
import { PersonMiniDTO } from 'src/app/pages/clientes/list/list.component';

@Component({
  selector: 'app-detailsperson-comp',
  templateUrl: './detailsperson-comp.component.html',
  styleUrls: ['./detailsperson-comp.component.scss']
})
export class DetailspersonCompComponent {
  private _baseUrl = 'https://localhost:7152';

  clientId: string = '';
  clientExist: boolean = false;
  clientPost: ClientePostDTO = {
    id: '',
    userName: '',
    saldo: 0,
    personId: '',
    estado: EstadoType.Casado,
  }

  client: ClienteMiniDTO = {
    id: '',
    userName: '',
    saldo: 0,
    personId:'',
    name:'',
    surname1:'',
    surname2:'',
    age: '',
    estado: EstadoType.Casado,
    estadoString: ''
  };

  selectedPersonId: string = '';
  personasList: PersonMiniDTO[] = [];
  personaSelected: PersonMiniDTO = {
    id: '',
    name: '',
    surname1: '',
    surname2: '',
    age: ''
  };

  // enumOptions: string[] = ['Casado', 'Soltero', 'Divorciado']
  enumOptions1 = Object.values(EstadoType).filter(option => typeof option === 'string').map(value => String(value));

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

      this.getPersoList()
    });
  }

  async getDataClient(clientid: string){
    console.log(clientid);
    await this.httpClient.post(`${this._baseUrl}/Customer/GetCustomerById/${clientid}`, {Id: clientid}).pipe(
      map((response: any) => {
        console.log(response);
        this.client = response;
        this.selectedPersonId = this.client.personId;
        this.onSelectPerson();
      })
    ).toPromise();
  }

  async getPersoList() {
    return await this.httpClient.get(`${this._baseUrl}/Person/GetListPerson`).pipe(
      map((response: any) => {
        console.log(response);
        const asObject: ClienteMiniDTO[] = response;
        this.personasList = asObject;
        return asObject;
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
    this.goBack();
  }

  async onSelectPerson() {
    await this.httpClient.post(`${this._baseUrl}/Person/GetPersonById/${this.selectedPersonId}`, { id: this.selectedPersonId }).pipe(
      map((response: any) => {
        this.personaSelected = response;
      })
    ).toPromise();
  }

  async onChangeEstado(event: any) {
    this.client.estado = Number(event);
  }

  onSelectEstado(event: string): number {
    switch (event) {
      case 'Casado':
       return 0;
      case 'Soltero':
        return 1;
      case 'Divorciado':
        return 2;
      default:
        return 0;
    }
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
  age: string,
  estado: EstadoType,
  estadoString: string
}

export interface ClientePostDTO{
  id: string,
  userName: string,
  saldo: number,
  personId: string,
  estado: EstadoType
}

export enum EstadoType {
  Casado,
  Soltero,
  Divorciado,
}
