import { LoginGaurdGuard } from './guards/login-gaurd.guard';
import { AddComponent } from './add/add.component';
import { EditComponent } from './edit/edit.component';
import { DisplayComponent } from './display/display.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { MainPageComponent } from './main-page/main-page.component';
import { LoginComponent } from './login/login.component';
import { StudentPageComponent } from './student-page/student-page.component';
import { StudentGuardGuard } from './guards/student-guard.guard';

const routes: Routes = [
  {path:"",redirectTo:"mainPage",pathMatch:'full'},
  {path:"mainPage",component:MainPageComponent},
  {path:"login",component:LoginComponent},
  {path:"crud",component:AppComponent},
  {path:"Display",component:DisplayComponent,canActivate:[LoginGaurdGuard]},
    {path:"edit/:id",component:EditComponent},
    {path:"add",component:AddComponent},
    {path:'student',component:StudentPageComponent,canActivate:[StudentGuardGuard]}

  

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
