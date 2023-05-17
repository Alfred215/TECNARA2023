import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DetailsComponent } from './details.component';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';

const routes: Routes = [
  { path: '', component: DetailsComponent, },
];

@NgModule({
  declarations: [
    DetailsComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    FormsModule
  ],
  exports:[
    DetailsComponent
  ]
})
export class DetailsModule { }
