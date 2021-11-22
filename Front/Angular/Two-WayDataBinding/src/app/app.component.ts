import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TWO-WAY DATA BINDING';
  nome = 'Maria';
  Pessoa = {
    Nome   : "Maria",
    Idade  : 30
  }
}
