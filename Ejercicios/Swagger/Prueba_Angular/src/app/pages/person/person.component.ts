import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.scss']
})
export class PersonComponent implements OnInit {
  private _baseUrl = 'https://localhost:7152';

  personasList: PersonMiniDTO[] = []
  
  constructor(
    private httpClient: HttpClient,
    private readonly router: Router,
    private toastrService: ToastrService
  ) { }

  async ngOnInit() {
    await this.getDataListFilterPerson();
  }

  async getDataListFilterPerson() {
    return await this.httpClient.get(`${this._baseUrl}/Person/GetListPerson`).pipe(
      map((response: any) => {
        console.log(response);
        const asObject: PersonMiniDTO[] = response;
        this.personasList = asObject;
        return asObject;
      })
    ).toPromise();
  }
}

export interface PersonMiniDTO {
  id: string,
  name: string,
  surname1: string,
  surname2: string,
  age: string
}