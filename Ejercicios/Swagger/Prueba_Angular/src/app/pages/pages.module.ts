import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  /** Authentication layout */
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  {
    path: 'dashboard',
    loadChildren: () => import('./home/home.module').then(m => m.HomeModule),
    canLoad: [], canActivate: [],
  },
  {
    path: 'cliente',
    loadChildren: () => import('./clientes/clientes.module').then(m => m.ClientesModule),
    canLoad: [], canActivate: [],
  },
  {
    path: 'persona',
    loadChildren: () => import('./person/person.module').then(m => m.PersonModule),
    canLoad: [], canActivate: [],
  },

]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
  ]
})
export class PagesModule { }
