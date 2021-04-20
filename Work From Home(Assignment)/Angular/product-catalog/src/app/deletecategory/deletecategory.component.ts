import { Component, OnInit } from '@angular/core';
import { CategoryserviceService } from '../categoryservice.service';

@Component({
  selector: 'app-deletecategory',
  templateUrl: './deletecategory.component.html',
  styleUrls: ['./deletecategory.component.css']
})
export class DeletecategoryComponent implements OnInit {

  constructor(private categoryservice : CategoryserviceService) { }
  catid : number;
  message : string;
  ngOnInit(): void {
  }
  submit(){
    this.categoryservice.removeId=this.catid;
    this.categoryservice.remove()
    this.message="Category deleted successfully";
    
  }
}
