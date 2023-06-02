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
  productsData:any;
  lastProductID=1;
  imagePath="";
  checkImageUpload=false;
  ngOnInit(): void {
    this.AdminApiService. getAllProducts().subscribe((data:any)=>{
      this.productsData=data;
      
      this.lastProductID = this.productsData.reduce((maxId: number, prod: any) => {

        return Math.max(maxId, prod.id);

      }, 0);
      
    })

    this.setImage();
  }
  productsForm=this.formBuilder.group({
    id:this.formBuilder.control({value:'',disabled:true}),
    name:this.formBuilder.control('',Validators.required),
    price:this.formBuilder.control('',Validators.required),
    discount:this.formBuilder.control('',Validators.required),
    description:this.formBuilder.control('',Validators.required),
    images:this.formBuilder.control({value:'',disabled:true}),
    productCategory:this.formBuilder.control('',Validators.required),
    productSubCategory:this.formBuilder.control('',Validators.required),
    gender:this.formBuilder.control('',Validators.required),
  })


  uploadImage(event:any):void{
    
      const file:File=event.target.files[0];
      const int16Array = new Int16Array([this.lastProductID]);

      this.AdminApiService.uploadImage(int16Array,file).subscribe((successResponse)=>{
        this.imagePath=successResponse;
        alert("Image Uploaded Successfully.......");
        this.checkImageUpload=true;
        console.log(successResponse);
      });
    
  }

  setImage():void{
    if(this.lastProductID==1){
      this.imagePath="assets/defaultImg.png";
      console.log(this.imagePath);
       
    }
   
  }

  saveForm():void{
    if(this.productsForm.valid && this.checkImageUpload){
      this.productsForm.value.images=this.imagePath
     console.log(this.productsForm);
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
