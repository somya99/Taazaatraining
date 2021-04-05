import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-myglobalerror',
  templateUrl: './myglobalerror.component.html',
  styleUrls: ['./myglobalerror.component.css']
})
export class MyglobalerrorComponent implements OnInit {

  constructor() { }
  imgSource1 = '../assets/mygerrorhtml.PNG';
  imgSource2 = '../assets/mygerrorts.PNG';
  imgSource3 = '../assets/provider.PNG';
  
  errors : any = undefined;
  
  ngOnInit(): void {
  }
  
  getError() : void{
    this.errors.sort();
  }
  
}
