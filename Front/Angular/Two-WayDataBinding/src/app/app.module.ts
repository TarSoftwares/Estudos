import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MeuFormModule } from './meu-form/meu-form.module';
import { MeuForm2Component } from './meu-form2/meu-form2.component';
import { MeuForm2Module } from './meu-form2/meu-form2.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    MeuFormModule    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
