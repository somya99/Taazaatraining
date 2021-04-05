import { ErrorHandler, NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TshirtdatabindingComponent } from './tshirtdatabinding/tshirtdatabinding.component';
import { HelloComponent } from './hello/hello.component';
import { ProductComponent } from './product/product.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { PurchaseorderComponent } from './purchaseorder/purchaseorder.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatExpansionModule } from '@angular/material/expansion';
import { MyerrorhandlerService } from './myerrorhandler.service';
import { Child1Component } from './child1/child1.component';
import { Child2Component } from './child2/child2.component';
import { ChangecolorDirective } from './changecolor.directive';
import { ColorattributeComponent } from './colorattribute/colorattribute.component';
import { NcomponentComponent } from './ncomponent/ncomponent.component';
import { AppRoutingModule } from './app-routing.module';
import { HomeComponent } from './home/home.component';
import { MyglobalerrorComponent } from './myglobalerror/myglobalerror.component'; 
@NgModule({
  declarations: [
    AppComponent,
    TshirtdatabindingComponent,
    HelloComponent,
    ProductComponent,
    PurchaseComponent,
    PurchaseorderComponent,
    Child1Component,
    Child2Component,
    ChangecolorDirective,
    ColorattributeComponent,
    NcomponentComponent,
    HomeComponent,
    MyglobalerrorComponent
  ],
  imports: [
    BrowserModule, 
    FormsModule, BrowserAnimationsModule,
    AppRoutingModule,
    MatExpansionModule
  ],
  providers: [{provide: ErrorHandler, useClass: MyerrorhandlerService}],
  bootstrap: [AppComponent]
})
export class AppModule { }
