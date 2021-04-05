import { Component, OnInit } from '@angular/core';
import { ChildserviceService } from '../childservice.service';

@Component({
  selector: 'app-child1',
  templateUrl: './child1.component.html',
  styleUrls: ['./child1.component.css']
})
export class Child1Component implements OnInit {
  data : number;
  constructor(private getservice : ChildserviceService) { }

  ngOnInit(): void {  
  }
  setData(){
    this.getservice.setPrice(this.data);
  }
}
