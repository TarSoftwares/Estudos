import { NumberFormatStyle } from '@angular/common';
import { Component, EventEmitter, Input, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-meu-primeiro2',
  templateUrl: './meu-primeiro2.component.html',
  styleUrls: ['./meu-primeiro2.component.css']
})
export class MeuPrimeiro2Component implements OnInit { 
  @Input() valor: number = 0;
  mudouValor = new EventEmitter(); 
  Numero : number = 10;  
  ngOnInit(): void {
  }  
  Incrementar():void {
     this.Numero++;           
     this.mudouValor.emit({novoValor : this.valor});
  }
  Decrementar():void{
    this.Numero--;
    this.mudouValor.emit({novoValor : this.valor});
  }

}
