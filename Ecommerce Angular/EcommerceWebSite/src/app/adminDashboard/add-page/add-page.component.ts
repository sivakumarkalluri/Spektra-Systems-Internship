import { AdminService } from 'src/app/services/admin/admin.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-page',
  templateUrl: './add-page.component.html',
  styleUrls: ['./add-page.component.css']
})
export class AddPageComponent implements OnInit{

  constructor(private route:Router,private AdminApiService:AdminService,private formBuilder:FormBuilder){}
  ngOnInit(): void {
      
  }
  productsForm=this.formBuilder.group({
    id:this.formBuilder.control({value:'',disabled:true}),
    name:this.formBuilder.control('',Validators.required),
    price:this.formBuilder.control('',Validators.required),
    discount:this.formBuilder.control('',Validators.required),
    description:this.formBuilder.control('',Validators.required),
    image:this.formBuilder.control('',Validators.required),
  })

  saveForm():void{
    if(this.productsForm.valid){
     
      this.AdminApiService.addData(this.productsForm.value).subscribe((response:any)=>{
        if(confirm("Product Added Successfully....")==true){
          this.getHome();
        }

      });
    }
  }
  getHome():void{
    this.route.navigate(['crudPage']);
  }


}
