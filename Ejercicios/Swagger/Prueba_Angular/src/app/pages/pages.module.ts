import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  /** Authentication layout */
  { path: '', redirectTo: 'cliente', pathMatch: 'full' },
  {
    path: 'cliente',
    loadChildren: () => import('./clientes/clientes.module').then(m => m.ClientesModule),
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
