import {NgModule} from '@angular/core';
import {RouterModule,Routes} from '@angular/router';
import {ProductComponent} from './product/product.component';
import {PurchaseComponent} from './purchase/purchase.component';
import {TshirtdatabindingComponent} from './tshirtdatabinding/tshirtdatabinding.component';
import {ColorattributeComponent} from './colorattribute/colorattribute.component';
import {NcomponentComponent} from './ncomponent/ncomponent.component';
import {HomeComponent} from './home/home.component';
import {MyglobalerrorComponent} from './myglobalerror/myglobalerror.component';
import {LoginformComponent} from './loginform/loginform.component';
const routes: Routes= [
    {path: 'home', component: HomeComponent},
    {path: 'login', component: LoginformComponent},
    {path: 'databinding', component: TshirtdatabindingComponent},
    {path: 'product', component: ProductComponent},
    {path: 'purchase', component: PurchaseComponent},
    {path: 'colorattribute', component: ColorattributeComponent},
    {path: 'unrelatedcomponent', component: NcomponentComponent},
    {path: 'globalerror', component: MyglobalerrorComponent},
    {path: '', redirectTo:'home', pathMatch:"full"}
];

@NgModule({
    imports:[
        RouterModule.forRoot(routes)
    ],
    exports:[
        RouterModule
    ],
    
})
export class AppRoutingModule{}