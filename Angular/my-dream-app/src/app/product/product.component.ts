import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidatorFn } from '@angular/forms';
import { DataService } from '../data.service';
import { IProduct } from '../product/IProduct';

// function priceRangeValidator(min : number, max : number) : ValidatorFn
// {
//   return (control : AbstractControl) : {[key : string] : boolean} | null =>
//   {
//     if(control.value !== undefined && (isNaN(control.value) || control.value < min || control.value > max) ){
//       return {'priceRange' : true};
//     }
//     return null;
//   };
// }

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products : IProduct[] = [];
  // min = 0;
  // max = 1000;
  // productForm : FormGroup;
  constructor(private dataservice : DataService) { }
  searchText : string;
  searchPrice : number;
  ngOnInit(): void {
    this.products = this.dataservice.getProducts();
    // console.log(this.products);
    // this.productForm = new FormGroup({
      
    //   Price : new FormControl(null, [priceRangeValidator(this.min, this.max)])
    // });
  }

  

}
