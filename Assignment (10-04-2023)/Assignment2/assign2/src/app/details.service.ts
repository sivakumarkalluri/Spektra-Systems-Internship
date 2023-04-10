import { Injectable } from '@angular/core';
import { items } from './items';

@Injectable({
  providedIn: 'root'
})
export class DetailsService {


  productDetails!:items[];
  getDetails():items[]{
    
    this.productDetails=[
    {id:"101",itemName:"H & M Shirt",type:"Men's Wear",price:50,qty:1},
    {id:"102",itemName:"Wild Craft Bag",type:"Bags",price:200,qty:1},
    {id:"103",itemName:"Levis geans",type:"Men's Wear",price:70,qty:1},
    {id:"104",itemName:"Sky Bags",type:"Bags",price:250,qty:1},
    {id:"105",itemName:"Allen Solly Shirt",type:"Men's Wear",price:80,qty:1},

  ]

  return this.productDetails
}

  constructor() { }
}
