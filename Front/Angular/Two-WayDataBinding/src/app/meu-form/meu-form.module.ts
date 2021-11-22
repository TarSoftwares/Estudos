import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MeuFormComponent } from './meu-form.component';
import { MeuForm2Component } from '../meu-form2/meu-form2.component';
import { MeuForm2Module } from '../meu-form2/meu-form2.module';



@NgModule({
  declarations: [
    MeuFormComponent
  ],
  imports: [
    CommonModule    
  ],
  exports :[
    MeuFormComponent
  ]
})
export class MeuFormModule { }
