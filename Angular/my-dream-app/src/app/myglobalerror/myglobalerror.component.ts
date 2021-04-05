import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-myglobalerror',
  templateUrl: './myglobalerror.component.html',
  styleUrls: ['./myglobalerror.component.css']
})
export class MyglobalerrorComponent implements OnInit {

  constructor() { }
  imgSource1 = '../assets/myglobalerrorhtml.jpg';
  imgSource2 = '../assets/myglobalerrorts.jpg';
  imgSource3 = '../assets/provide.jpg';
  
  errors : any = undefined;
  
  ngOnInit(): void {
  }
  
  getError() : void{
    this.errors.sort();
  }
  
}
