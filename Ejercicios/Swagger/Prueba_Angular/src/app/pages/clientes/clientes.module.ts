import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientesComponent } from './clientes.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = [
  { path: '', component: ClientesComponent, },
  {
    path: 'new', loadChildren: () => import('./details/details.module').then(m => m.DetailsModule),
  },
  {
    path: 'details/:id', loadChildren: () => import('./details/details.module').then(m => m.DetailsModule),
  },
];

@NgModule({
  declarations: [
    ClientesComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    HttpClientModule
  ]
})
export class ClientesModule { }
