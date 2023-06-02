import { UserService } from './../services/user/user.service';
import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin/admin.service';
import { Router } from '@angular/router';
import { LoginService } from '../services/login/login.service';
import { PurchasedService } from '../services/purchased/purchased.service';
import { FormBuilder, FormControl } from '@angular/forms';
import { __values } from 'tslib';

@Component({
  selector: 'app-products-page',
  templateUrl: './products-page.component.html',
  styleUrls: ['./products-page.component.css']
})
export class ProductsPageComponent implements OnInit{
  
  constructor(private AdminApiService:AdminService,private route:Router,
    private loginServe:LoginService,private userApiService:UserService,private purchaseServe:PurchasedService,private formBuilder:FormBuilder){}
 
  productDetails:any;
  isAddedToCart: boolean = false;
  totalProductsNum=0;
  allProducts:any;
  pageNumber=1;
  genderFilter="";
  sortByFilter="";
  sortBy=false;


  pagesArray: number[] = [];  NoOfPages=1;

  
  ngOnInit(): void {
      this.AdminApiService.getData(this.genderFilter,this.sortByFilter,this.sortBy,this.pageNumber).subscribe((data:any)=>{
        this.productDetails=data;
        console.log(this.productDetails);
       
        
      })
      this.AdminApiService.getAllProducts().subscribe((data:any)=>{
        this.allProducts=data;
        this.totalProductsNum=this.allProducts.length;
        this.NoOfPages = Math.ceil(this.totalProductsNum / 6);
        console.log(this.NoOfPages);
        console.log(this.totalProductsNum);
        for (let i = 1; i <= this.NoOfPages; i++) {
          this.pagesArray.push(i);
        }
      })
      
     
  }

  FilterForm=this.formBuilder.group({
    gender: new FormControl(),
    sortBy:new FormControl()
   
  })

 sort(){
  
  this.sortByFilter="price";
  console.log(this.sortByFilter);
 }
applyFilter():void{
  this.genderFilter=this.FilterForm.value.gender;
  this.sortBy=this.FilterForm.value.sortBy;
 
  console.log("Sort BY: "+this.sortBy);
  
  this.AdminApiService.getData(this.genderFilter,this.sortByFilter,this.sortBy,this.pageNumber).subscribe((data:any)=>{
    this.productDetails=data;
    console.log(this.productDetails);
   
    
  })
  console.log(this.genderFilter);
  

}


  updatePageData(page:any){
    this.pageNumber=page;
    this.AdminApiService.getData(this.genderFilter,this.sortByFilter,this.sortBy,this.pageNumber).subscribe((data:any)=>{
      this.productDetails=data;
      console.log(this.productDetails);
     
      
    })


  }

  initializeProductFlags() {
    this.productDetails.forEach((product:any) => {
      product.isAddedToCart = false;
    });
  }
  onSelect(id:number){
    this.route.navigate(['productDetails',id]);
  }

  addToCart(id:number){
    
    if(localStorage.getItem('role') == 'user'){
      const selectedProduct = this.productDetails.find((product: any) => product.id === id);
      if (selectedProduct) {
        const cartItem = {
          id: selectedProduct.id,
          name: selectedProduct.name,
          price: selectedProduct.price,
          quantity: 1,
          discount: selectedProduct.discount,
          description: selectedProduct.description,
          image: selectedProduct.image
        };
        this.userApiService.addData(cartItem).subscribe((response: any) => {
          console.log('Product added to cart:', response);selectedProduct.isAddedToCart = true;
          setTimeout(() => {
            selectedProduct.isAddedToCart = false;
          }, 2000);
        });
        
      }
    }
    else{
      this.route.navigate(['login']);
    }
  
  }
    
  }


