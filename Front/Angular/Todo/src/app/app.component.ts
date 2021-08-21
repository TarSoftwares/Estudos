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
        Validators.minLength(5),
        Validators.maxLength(50),
        Validators.required])] 
      });
    // this.Todos.push(new Todo(1,false,'estudar'));
    // this.Todos.push(new Todo(2,false,'dormir'));
    // this.Todos.push(new Todo(3,true,'finalizar aula anterior'));     
  }
  add(){
    const title = this.form.controls['title'].value;
    const id    = this.Todos.length + 1 ;
    this.Todos.push(new Todo(id,false,title));
    this.clear();
  }
  clear(){
    this.form.reset();
  }

  changeText()  
  {
    if (this.title == "Minhas Tarefas")
      this.title = "Lista de Tarefas"
    else
      this.title = "Minhas Tarefas";  
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
