import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Todo } from 'src/models/todo.models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public Todos : Todo [] = [];  
  public title : String = "Minhas Tarefas";
  public form : FormGroup;
  constructor(private fb : FormBuilder) {
    this.form = this.fb.group({
      title: ['',Validators.compose([
        Validators.minLength(3),
        Validators.maxLength(50),
        Validators.required])] 
      });
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
