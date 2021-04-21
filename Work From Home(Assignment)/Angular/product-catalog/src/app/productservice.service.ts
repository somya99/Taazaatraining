import { Injectable } from '@angular/core';
import { IProduct } from './product/IProduct';

@Injectable({
  providedIn: 'root'
})
export class ProductserviceService {
  product : IProduct[] = [
    {
      ProductId : 1,
      ProductName : "Cup",
      Manufacturer : "Gala",
      ProductShortCode : "CUP",
      Category : "Crockery",
      Description : "Used in kitchen",
      SellingPrice : 250,
    },
    {
      ProductId : 2,
      ProductName : "Pen",
      Manufacturer : "Classmate",
      ProductShortCode : "PEN",
      Category : "Stationary",
      Description : "Used for creating",
      SellingPrice : 100,
    },
    {
      ProductId : 3,
      ProductName : "Bread",
      Manufacturer : "Britannia",
      ProductShortCode : "BRD",
      Category : "Food",
      Description : "Used to eat",
      SellingPrice : 120,
    },
    {
      ProductId : 4,
      ProductName : "Pencil",
      Manufacturer : "Classmate",
      ProductShortCode : "PNCL",
      Category : "Stationary",
      Description : "Used for creating",
      SellingPrice : 50,
    },
    {
      ProductId : 5,
      ProductName : "Plate",
      Manufacturer : "Gala",
      ProductShortCode : "PLT",
      Category : "Crockery",
      Description : "Used in Kitchen",
      SellingPrice : 400,
    },
  ];
  id : number;
  name : string;
  manu : string;
  shortcode : string;
  category : string;
  description : string;
  price : number;
  constructor() { }
  removeId! : number;
  getProduct() : IProduct[] {
    return this.product;
  }

  addProduct() : IProduct[]{
    this.product.push({
      ProductId : this.id,
      ProductName : this.name,
      Manufacturer : this.manu,
      ProductShortCode : this.shortcode,
      Category : this.category,
      Description : this.description,
      SellingPrice : this.price
    });
    return this.product;
  }
  remove() {
    this.product = this.product.filter(item => item.ProductId !==this.removeId);
  }
}
