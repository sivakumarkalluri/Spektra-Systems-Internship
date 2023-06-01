import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AdminService } from 'src/app/services/admin/admin.service';

@Component({
  selector: 'app-edit-page',
  templateUrl: './edit-page.component.html',
  styleUrls: ['./edit-page.component.css']
})
export class EditPageComponent implements OnInit{

  constructor(private route:Router,private AdminApiService:AdminService,private activeRoutes:ActivatedRoute,private formBuilder:FormBuilder){}
  editedID!:number;
  editingData:any;
  ngOnInit(): void {
      this.editedID=this.activeRoutes.snapshot.params['id'];
      this.AdminApiService.getDataByID(this.editedID).subscribe((data:any)=>{
        this.editingData=data;
        this.initialiseForm()
      })
      

  }
  productsForm=this.formBuilder.group({
    id:this.formBuilder.control({value:'',disabled:true}),
    name:this.formBuilder.control('',Validators.required),
    price:this.formBuilder.control('',Validators.required),
    discount:this.formBuilder.control('',Validators.required),
    description:this.formBuilder.control('',Validators.required),
    image:this.formBuilder.control('',Validators.required),
    productCategory:this.formBuilder.control('',Validators.required),
    productSubCategory:this.formBuilder.control('',Validators.required),
    gender:this.formBuilder.control('',Validators.required),


    

  })

  initialiseForm():void{
    if(this.editingData){
      this.productsForm.patchValue({
        id:this.editingData.id,
        name:this.editingData.name,
        price:this.editingData.price,
        discount:this.editingData.discount,
        description:this.editingData.description,
        image:this.editingData.image,
        productCategory:this.editingData.productCategory,
        productSubCategory:this.editingData.productSubCategory,
        gender:this.editingData.gender,



      })
    }

  }
  saveForm():void{
    if(this.productsForm.valid){
      this.AdminApiService.editData(this.editedID,this.productsForm.value).subscribe((response:any)=>{
        if(confirm("Edited Successfully...")==true){
          this.getHome();
        }
      })
    }
  }
  getHome():void{
    this.route.navigate(['crudPage']);
  }

}
