import { UserService } from './../services/user/user.service';
import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin/admin.service';
import { Router } from '@angular/router';
import { LoginService } from '../services/login/login.service';
import { PurchasedService } from '../services/purchased/purchased.service';

@Component({
  selector: 'app-products-page',
  templateUrl: './products-page.component.html',
  styleUrls: ['./products-page.component.css']
})
export class ProductsPageComponent implements OnInit{
  
  constructor(private AdminApiService:AdminService,private route:Router,
    private loginServe:LoginService,private userApiService:UserService,private purchaseServe:PurchasedService){}
 
  productDetails:any;
  imagesData:any;
  isAddedToCart: boolean = false;

  
  ngOnInit(): void {
      this.AdminApiService.getData().subscribe((data:any)=>{
        this.productDetails=data;
        this.initializeProductFlags();
      })
      this.AdminApiService.getImages().subscribe((imageData: any) => {
        this.imagesData = imageData;
      });
  }

  
  findImagePath(id:number):string{
      var result="";
      const matchingImage = this.imagesData.find((image: any) => image.id === id);
      if (matchingImage) {
        result = matchingImage.filePath;
      }
      return result;
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


