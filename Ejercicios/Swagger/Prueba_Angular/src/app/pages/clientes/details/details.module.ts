import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DetailsComponent } from './details.component';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { ModalCompModule } from 'src/app/shared/component/modal-comp/modal-comp.module';

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
    FormsModule,
    ModalCompModule
  ],
  exports:[
    DetailsComponent
  ]
})
export class DetailsModule { }
