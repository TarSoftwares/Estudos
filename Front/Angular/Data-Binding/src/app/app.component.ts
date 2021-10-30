import { Component } from '@angular/core';
import * as moment from 'moment';
import 'moment/locale/pt-br';

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
  // const moment = require('moment');  
  // let now = moment().format('LLLL');
  dataFinal : any;
  dataNasc = moment(new Date()).format("DD/MM/YYYY");     
  constructor (){
    this.dataFinal = this.dataNasc;
  }
  
  somar(_num1 : number,_num2 : number)  
  {
    this.resultado = Number(_num1) + Number(_num2);  
    return this.resultado;
  }
  pessoa  : any = {
    nome  : 'Maria',
    idade : 24
  }  
  onCalcularData(data: any, dias: number): string{    
    let dtFim : any;   
    dtFim = moment(data).add(dias,'days').format('DD/MM/YYYY');
    this.dataFinal = dtFim;
    return dtFim;
  }
  FormatarData(data : any){
    return data.split('/').reverse().join('-');
  }
  FormatarData2(data : any, dias:number) : Date{
     let dt = new Date(moment(data).add(dias).format('DD/MM/YYYY'));
     return dt;
  }

}
