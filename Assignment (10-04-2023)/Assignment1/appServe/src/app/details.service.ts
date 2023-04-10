import { Injectable } from '@angular/core';
import { details } from './details';
@Injectable({
  providedIn: 'root'
})
export class DetailsService {

  info:details[]=[
    {id:'101',firstName:'Siva',country:'India',age:21},
    {id:'102',firstName:'Kumar',country:'India',age:20},
    {id:'103',firstName:'Kalluri',country:'India',age:19}
  ]
getInfo():details[]{
  console.log(this.info);
  return this.info;
    
}
// getTitle():string{
//   console.log("hello");
//   return "Hello world";
// }

  constructor() { }
}
