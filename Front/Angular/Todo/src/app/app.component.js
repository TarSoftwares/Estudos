"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
exports.__esModule = true;
exports.AppComponent = void 0;
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var todo_models_1 = require("src/app/models/todo.models");
var AppComponent = /** @class */ (function () {
    function AppComponent(fb) {
        this.fb = fb;
        this.Todos = [];
        this.title = "Tarefas";
        this.mode = "list";
        this.form = this.fb.group({
            title: ['', forms_1.Validators.compose([
                    forms_1.Validators.minLength(5),
                    forms_1.Validators.maxLength(50),
                    forms_1.Validators.required
                ])]
        });
        // this.Todos.push(new Todo(1,false,'estudar'));
        // this.Todos.push(new Todo(2,false,'dormir'));
        // this.Todos.push(new Todo(3,true,'finalizar aula anterior'));     
        this.load();
    }
    AppComponent.prototype.setFocus = function () {
        // this.txtTitulo.nativeElement.focus(); 
    };
    AppComponent.prototype.add = function () {
        var title = this.form.controls['title'].value;
        var id = this.Todos.length + 1;
        this.Todos.push(new todo_models_1.Todo(id, false, title));
        this.save();
        this.clear();
    };
    AppComponent.prototype.clear = function () {
        this.form.reset();
    };
    AppComponent.prototype.changeText = function () {
        if (this.title == "Tarefas")
            this.title = "Lista de Tarefas";
        else
            this.title = "Tarefas";
    };
    AppComponent.prototype.save = function () {
        var data = JSON.stringify(this.Todos);
        //'todos' nome da chave armazenada
        localStorage.setItem('todos', data);
    };
    AppComponent.prototype.load = function () {
        //minha Lista 'todos' sendo carregada
        var data = localStorage.getItem('todos');
        //Erro - atualizando Todos com o JSON recuperado de localStorage, já com o parse.
        //Aplicação quebra aqui 
        this.Todos = JSON.parse(localStorage['todos']);
    };
    AppComponent.prototype.remove = function (todo) {
        var item = this.Todos.indexOf(todo);
        if (item !== -1) {
            this.Todos.splice(item, 1);
            this.save();
        }
    };
    AppComponent.prototype.markAsDone = function (todo) {
        todo.done = true;
        this.save();
    };
    AppComponent.prototype.markAsUndone = function (todo) {
        todo.done = false;
        this.save();
    };
    AppComponent.prototype.changeMode = function (mode) {
        this.mode = mode;
    };
    AppComponent = __decorate([
        (0, core_1.Component)({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
