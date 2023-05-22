import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonComponent } from './person.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ModalCompModule } from 'src/app/shared/component/modal-comp/modal-comp.module';

const routes: Routes = [
  { path: '', component: PersonComponent, },
];

@NgModule({
  declarations: [
    PersonComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    HttpClientModule,
    ModalCompModule
  ]
})
export class PersonModule { }
