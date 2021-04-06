import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { ChildserviceService } from '../childservice.service';
import { IProduct } from '../product/IProduct';

function priceRangeValidator(min : number, max : number) : ValidatorFn
{
  return (control : AbstractControl) : {[key : string] : boolean} | null =>
  {
    if(control.value !== undefined && (isNaN(control.value) || control.value < min || control.value > max) ){
      return {'priceRange' : true};
    }
    return null;
  };
}

@Component({
  selector: 'app-child1',
  templateUrl: './child1.component.html',
  styleUrls: ['./child1.component.css']
})
export class Child1Component implements OnInit {
  product : IProduct;
  min = 1;
  max = 1000;
  productForm : FormGroup;
  constructor(private getservice : ChildserviceService) { }

  ngOnInit(): void {
    this.getservice.product$.subscribe(data => {
      this.product = data;
    })
    this.productForm = new FormGroup({
      Id : new FormControl(this.product?.Id, [Validators.required]),
      Title : new FormControl(this.product?.Title, [Validators.required]),
      Price : new FormControl(this.product?.Price, [priceRangeValidator(this.min, this.max)]),
      ExpiryDate : new FormControl(this.product?.ExpiryDate,[Validators.required]),
      isInStock : new FormControl(this.product?.isInStock, [Validators.required]),
      Quantity : new FormControl(this.product?.Quantity, [Validators.required])
    });  
  }
  // setData(){
  //   this.getservice.setPrice(this.data);
  // }

  updateProduct(){
    console.log(this.productForm.value);
    //console.log(p);
    this.getservice.updateProduct(this.productForm.value);
  }

  cancel(){
    // this.productForm.reset();
  }
}
