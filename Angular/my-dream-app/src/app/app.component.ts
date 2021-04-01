import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular Demo';
  showImageChangeDemo = true;
  showProductListDemo = false;
  showMasterDetails = false;
  showimagechangedemo(): void{
    this.showImageChangeDemo = true;
    this.showProductListDemo = false;
    this.showMasterDetails = false;
  }

  showproductlistdemo(): void{
    this.showImageChangeDemo = false;
    this.showProductListDemo = true;
    this.showMasterDetails = false;
  }
  
  showmasterdetails(): void{
    this.showImageChangeDemo = false;
    this.showProductListDemo = false;
    this.showMasterDetails = true;
  }
  
}
