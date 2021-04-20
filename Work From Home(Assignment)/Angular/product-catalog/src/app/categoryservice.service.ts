import { Injectable } from '@angular/core';
import { ICategory } from './category/ICategory';

@Injectable({
  providedIn: 'root'
})
export class CategoryserviceService {
  category : ICategory[] = [];
  constructor() { }
  id : number;
  name : string;
  shortcode : string;
  description : string;
  removeId : number;
  getCategory() : ICategory[] {
    return[
      {
        CategoryId : 1,
        CategoryName : "Stationary",
        CategoryShortCode : "STN",
        Description : "Used for creating" 
      },
      {
        CategoryId : 2,
        CategoryName : "Food",
        CategoryShortCode : "FD",
        Description : "Used to eat" 
      },
      {
        CategoryId : 3,
        CategoryName : "Crockery",
        CategoryShortCode : "CRK",
        Description : "Used in kitchen" 
      },
    ]
  }
  addCategory() : ICategory[]{
    this.category.push({
      CategoryId : this.id,
      CategoryName : this.name,
      CategoryShortCode : this.shortcode,
      Description : this.description
    });
    return this.category;
  }
  remove() {
    this.category = this.category.filter(item => item.CategoryId !==this.removeId);
  }
}
