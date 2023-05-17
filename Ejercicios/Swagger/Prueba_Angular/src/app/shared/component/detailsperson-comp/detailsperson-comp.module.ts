import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DetailspersonCompComponent } from './detailsperson-comp.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    DetailspersonCompComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    DetailspersonCompComponent
  ]
})
export class DetailspersonCompModule { }
