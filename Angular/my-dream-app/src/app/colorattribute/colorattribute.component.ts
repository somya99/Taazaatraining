import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-colorattribute',
  templateUrl: './colorattribute.component.html',
  styleUrls: ['./colorattribute.component.css']
})
export class ColorattributeComponent implements OnInit {

  constructor() { }
  c = "green";
  ngOnInit(): void {
  }

}
