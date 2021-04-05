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
  showUnrelatedComponents = false;
  showAttributeDirective= false;
  showimagechangedemo(): void{
    this.showImageChangeDemo = true;
    this.showProductListDemo = false;
    this.showMasterDetails = false;
    this.showUnrelatedComponents = false;
    this.showAttributeDirective= false;
  }

  showproductlistdemo(): void{
    this.showImageChangeDemo = false;
    this.showProductListDemo = true;
    this.showMasterDetails = false;
    this.showUnrelatedComponents = false;
    this.showAttributeDirective= false;
  }
  
  showmasterdetails(): void{
    this.showImageChangeDemo = false;
    this.showProductListDemo = false;
    this.showMasterDetails = true;
    this.showUnrelatedComponents = false;
    this.showAttributeDirective= false;
  }

  showunrelatedcomponents(): void{
    this.showImageChangeDemo = false;
    this.showProductListDemo = false;
    this.showMasterDetails = false;
    this.showUnrelatedComponents = true;
    this.showAttributeDirective= false;
  }
  
  showattributedirective(): void{
    this.showImageChangeDemo = false;
    this.showProductListDemo = false;
    this.showMasterDetails = false;
    this.showUnrelatedComponents = false;
    this.showAttributeDirective= true;
  }
}
