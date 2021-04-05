import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { IProduct } from './product/IProduct';


@Injectable({
  providedIn: 'root'
})
export class ChildserviceService {
  product : IProduct = {
    Id : 6,
    Title : "Uncle Chips",
    Price : 200,
    ExpiryDate : "07-24-2020",
    isInStock : true,
    Quantity : 67
  }
  product$ : BehaviorSubject<IProduct>;
  constructor() { 
    this.product$ = new BehaviorSubject(this.product);
  }
  setPrice(price : number){
    this.product.Price = price;
    this.product$.next(this.product);

  }
  
}
