import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full' },
  {
    path: 'list', loadChildren: () => import('./list/list.module').then(m => m.ListModule),
  },
  {
    path: 'new', loadChildren: () => import('./details/details.module').then(m => m.DetailsModule),
  },
  {
    path: 'details/:id', loadChildren: () => import('./details/details.module').then(m => m.DetailsModule),
  },
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    HttpClientModule
  ]
})
export class ClientesModule { }
