import { Component, OnInit } from '@angular/core';
import { ICategory } from '../category/ICategory';
import { CategoryserviceService } from '../categoryservice.service';

@Component({
  selector: 'app-addcategory',
  templateUrl: './addcategory.component.html',
  styleUrls: ['./addcategory.component.css']
})
export class AddcategoryComponent implements OnInit {
  id : number;
  catid : number = 3;
  name : string;
  shortcode : string; 
  description : string;
  message : string;
  constructor(private categoryservice : CategoryserviceService) { }

  ngOnInit(): void {
    
  }
  submit(){
    this.categoryservice.id = this.catid;
    this.categoryservice.name = this.name;
    this.categoryservice.shortcode = this.shortcode;
    this.categoryservice.description = this.description;
    this.categoryservice.addCategory();
    this.message = "Category added successfully";
  }
}
