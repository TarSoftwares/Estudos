import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MeuForm2Component } from './meu-form2.component';
import { MeuFormModule } from '../meu-form/meu-form.module';



@NgModule({
  declarations: [
    MeuForm2Component
  ],
  imports: [
    CommonModule,
    MeuFormModule
  ],
  exports :[
    MeuForm2Component
  ]
})
export class MeuForm2Module { }
