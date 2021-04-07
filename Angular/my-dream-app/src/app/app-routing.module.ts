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
import {RxJSsubjectComponent} from './rx-jssubject/rx-jssubject.component';
import { SubjectComponent } from './subject/subject.component';
import { BehaviorsubjectComponent } from './behaviorsubject/behaviorsubject.component';
import { ReplaysubjectComponent } from './replaysubject/replaysubject.component';
import { AsyncsubjectComponent } from './asyncsubject/asyncsubject.component';
const routes: Routes= [
    {path: 'home', component: HomeComponent},
    {path: 'login', component: LoginformComponent},
    {path: 'databinding', component: TshirtdatabindingComponent},
    {path: 'product', component: ProductComponent},
    {path: 'purchase', component: PurchaseComponent},
    {path: 'colorattribute', component: ColorattributeComponent},
    {path: 'unrelatedcomponent', component: NcomponentComponent},
    {path: 'globalerror', component: MyglobalerrorComponent},
    {path: 'rxjssubject', component: RxJSsubjectComponent,
    children: [
        {
          path: 'subject', 
          component: SubjectComponent,
        },
        {
          path: 'behavioursubject',
          component:BehaviorsubjectComponent 
        },
        {
            path: 'replaysubject',
            component: ReplaysubjectComponent, 
          },
          {
            path: 'asyncsubject',
            component: AsyncsubjectComponent, 
          }
      ],},
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