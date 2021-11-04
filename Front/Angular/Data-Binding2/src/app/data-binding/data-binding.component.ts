import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.css']
})
export class DataBindingComponent implements OnInit {  
  constructor() { }
  ngOnInit(): void {
  }
  url : string = 'https://loiane.training/';
  urlImagem  : string  = 'http://lorempixel.com/400/200/sports/';
  urlImagem2 : string  = 'http://lorempixel.com/g/400/200/';
  getValor(){
    return 1;
  }
}
