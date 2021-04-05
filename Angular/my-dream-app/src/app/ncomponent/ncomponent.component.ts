import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ncomponent',
  templateUrl: './ncomponent.component.html',
  styleUrls: ['./ncomponent.component.css']
})
export class NcomponentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  showUnrelatedComponents1 = true;
  showUnrelatedComponents2 = true;
  

  // showunrelatedcomponents1(): void{
    
  //   this.showUnrelatedComponents1 = true;
  //   this.showUnrelatedComponents2 = true;
  // }
    
}
