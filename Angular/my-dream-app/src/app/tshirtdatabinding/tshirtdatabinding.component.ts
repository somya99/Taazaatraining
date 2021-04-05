import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tshirtdatabinding',
  templateUrl: './tshirtdatabinding.component.html',
  styleUrls: ['./tshirtdatabinding.component.css']
})
export class TshirtdatabindingComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  
  height = 300;
  width = 300;
   
   imgSource = '../assets/front1.jpg';

   changeTShirtMouseEnter(): void{
     this.imgSource = '../assets/back1.jpg';
   }
   changeTShirtMouseExit(): void{
      this.imgSource = '../assets/front1.jpg';
   }
   
}
