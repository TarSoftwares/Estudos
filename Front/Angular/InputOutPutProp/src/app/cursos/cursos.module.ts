import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CursosComponent } from './cursos.component';
import { CursoDetalheComponent } from './curso-detalhe/curso-detalhe.component';
import { CursosService } from './cursos.service';


@NgModule({
  declarations: [
    CursosComponent,
    CursoDetalheComponent  
  ],
  imports: [
    CommonModule //Diferença do módulo raiz para o de funcionalidade   
  ] ,
  exports:[
    CursosComponent
  ] ,
  providers :[ 
    CursosService
 ]
  
})
export class CursosModule { }
