import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'EventBinding';
  valorAtual : String = '';
  valorSalvo : String = '';
  isMouseOver : Boolean = false;

  BotaoClicado(){
    alert("Botão Clicado!");
  }  
  SalvarValor(valor : string = '' ){
     this.valorSalvo = valor;
  }
  onKeyUp(evento : KeyboardEvent){
    this.valorAtual =  (<HTMLInputElement>evento.target).value;  
    this.valorAtual = this.valorAtual.toUpperCase();
    console.log(this.valorAtual);
    
  }
  onMouseOver(){
    this.isMouseOver = !this.isMouseOver;
  }
}
