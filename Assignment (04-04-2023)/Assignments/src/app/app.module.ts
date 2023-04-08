import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ArraysComponent } from './arrays/arrays.component';
import { IfDirectiveComponent } from './if-directive/if-directive.component';
import { SwitchDirectiveComponent } from './switch-directive/switch-directive.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    ArraysComponent,
    IfDirectiveComponent,
    SwitchDirectiveComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule, BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
