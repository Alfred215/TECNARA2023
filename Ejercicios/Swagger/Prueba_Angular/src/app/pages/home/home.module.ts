import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ModalCompModule } from 'src/app/shared/component/modal-comp/modal-comp.module';

const routes: Routes = [
  { path: '', component: HomeComponent, },
];

@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    HttpClientModule,
    ModalCompModule
  ]
})
export class HomeModule { }
