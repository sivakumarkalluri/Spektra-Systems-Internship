import { DetailsComponent } from './details/details.component';
import { PersonsComponent } from './persons/persons.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', component: PersonsComponent },
  {path:'persons',component:PersonsComponent},
  { path: 'persons/:id', component: DetailsComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
}) 
export class AppRoutingModule { }

export const routingComponents =[PersonsComponent,DetailsComponent]