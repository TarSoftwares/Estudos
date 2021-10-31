import { NumberFormatStyle } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-meu-primeiro2',
  templateUrl: './meu-primeiro2.component.html',
  styleUrls: ['./meu-primeiro2.component.css']
})
export class MeuPrimeiro2Component implements OnInit { 
  Numero : number = 10;  
  ngOnInit(): void {
  }  
  Incrementar():void {
     this.Numero = this.Numero + 1;           
  }
  Decrementar():void{
    this.Numero = this.Numero - 1;
  }

}
