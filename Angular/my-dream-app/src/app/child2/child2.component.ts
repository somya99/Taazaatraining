import { Component, OnInit } from '@angular/core';
import { ChildserviceService } from '../childservice.service';
import { IProduct } from '../product/IProduct';

@Component({
  selector: 'app-child2',
  templateUrl: './child2.component.html',
  styleUrls: ['./child2.component.css']
})
export class Child2Component implements OnInit {
  iproduct : IProduct;
  constructor(private getservice : ChildserviceService) { }

  ngOnInit(): void {
    
    this.getservice.product$.subscribe(c => {
      this.iproduct = c;
  });
  }
  
  
}
