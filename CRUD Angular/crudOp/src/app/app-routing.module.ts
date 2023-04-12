import { EditFormComponent } from './edit-form/edit-form.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AddUserComponent } from './add-user/add-user.component';
import { CompanyComponent } from './company/company.component';

const routes: Routes = [
  {path:'',component:CompanyComponent},
  {path:'Home',component:CompanyComponent},
  {path:'HomeLink',component:AppComponent},
  {path:'addUserLink',component:AddUserComponent},
  {path:'editForm',component:EditFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
