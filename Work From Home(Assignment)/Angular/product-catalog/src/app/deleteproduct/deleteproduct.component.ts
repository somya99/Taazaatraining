import { Component, OnInit } from '@angular/core';
import { ProductserviceService } from '../productservice.service';

@Component({
  selector: 'app-deleteproduct',
  templateUrl: './deleteproduct.component.html',
  styleUrls: ['./deleteproduct.component.css']
})
export class DeleteproductComponent implements OnInit {

  constructor(private productservice : ProductserviceService) { }
  prodid : number;
  message : string;
  ngOnInit(): void {
  }
  submit(){
    this.productservice.removeId=this.prodid;
    this.productservice.remove()
    this.message="Product deleted successfully";
    
  }
}
