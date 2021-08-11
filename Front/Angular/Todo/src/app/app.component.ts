import { Component } from '@angular/core';
import { Todo } from 'src/models/todo.models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public Todos : Todo [] = [];  
  public title : String = "Minhas Tarefas";
  constructor() {
    this.Todos.push(new Todo(1,false,'estudar'));
    this.Todos.push(new Todo(2,false,'dormir'));
    this.Todos.push(new Todo(3,true,'finalizar aula anterior'));     
  }
  alterarTexto()  
  {
    if (this.title == "Teste")
      this.title = "Teste dinâmico"
    else
      this.title = "Teste";  
  }
  remove(todo : Todo)
  {
     const item = this.Todos.indexOf(todo);
     if (item !== -1)
     {
       this.Todos.splice(item,1);
     }
     
  }
  markAsDone(todo : Todo)
  {
    todo.done = true;
  }
  markAsUndone(todo : Todo)
  {
    todo.done = false;
  }
}
