import { AdminComponent } from './admin/admin.component';
import { StudentsComponent } from './students/students.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
// import { AppComponent } from './app.component';

const routes: Routes = [
  {path:'',component:StudentsComponent},
  {path:'StudentsLink',component:StudentsComponent},
  {path:'AdminLink',component:AdminComponent},
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
