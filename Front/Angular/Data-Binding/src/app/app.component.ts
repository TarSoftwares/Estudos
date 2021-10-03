import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  resultado : number = 0;
  title = 'Data-Binding';
  nome : string = "Tarso"; 
  num1 : number = 0;
  num2 : number = 0;
  somar(_num1 : number,_num2 : number)  
  {
    this.resultado = Number(_num1) + Number(_num2);  
    return this.resultado;
  }
  pessoa : any = {
    nome :  'Maria',
    idade :24
  }
}
