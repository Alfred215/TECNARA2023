import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list.component';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { DetailspersonCompModule } from 'src/app/shared/component/detailsperson-comp/detailsperson-comp.module';
import { ModalCompModule } from 'src/app/shared/component/modal-comp/modal-comp.module';

const routes: Routes = [
  { path: '', component: ListComponent, },
];

@NgModule({
  declarations: [
    ListComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    FormsModule,
    DetailspersonCompModule,
    ModalCompModule
  ]
})
export class ListModule { }
