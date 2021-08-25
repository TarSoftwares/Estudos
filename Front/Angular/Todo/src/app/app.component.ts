import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Todo } from 'src/app/models/todo.models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public Todos : Todo [] = [];  
  public title : String = "Tarefas";
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
    this.load();
  }
  add(){
    const title = this.form.controls['title'].value;
    const id    = this.Todos.length + 1 ;
    this.Todos.push(new Todo(id,false,title));
    this.save();
    this.clear();
  } 
  clear(){
    this.form.reset();
  }

  changeText()  
  {
    if (this.title == "Tarefas")
      this.title = "Lista de Tarefas"
    else
      this.title = "Tarefas";  
  } 
  save(){
    const data = JSON.stringify(this.Todos);
    //'todos' nome da chave armazenada
    localStorage.setItem('todos',data);
  }
  load()
  {
    //minha Lista 'todos' sendo carregada
     const data = localStorage.getItem('todos');    
     //Erro - atualizando Todos com o JSON recuperado de localStorage, já com o parse.
     //Aplicação quebra aqui 
     this.Todos = JSON.parse(localStorage['todos']);     
  }
  remove(todo : Todo)
  {
     const item = this.Todos.indexOf(todo);
     if (item !== -1)
     {
       this.Todos.splice(item,1);
       this.save();
     }
     
  }
  markAsDone(todo : Todo)
  {
    todo.done = true;
    this.save();
  }
  markAsUndone(todo : Todo)
  {
    todo.done = false;
    this.save();
  }
}
