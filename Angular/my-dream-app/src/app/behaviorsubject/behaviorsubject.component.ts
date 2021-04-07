import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { BehaviorsubjectserviceService } from '../behaviorsubjectservice.service';

@Component({
  selector: 'app-behaviorsubject',
  templateUrl: './behaviorsubject.component.html',
  styleUrls: ['./behaviorsubject.component.css']
})
export class BehaviorsubjectComponent implements OnInit {

  title = 'Behavior Subject Demo';
  observer1$: Subscription;
  observer2$: Subscription;
  observer3$: Subscription;
  observer1 = [];
  observer2 = [];
  observer3 = [];
  showObserver1 = false;
  showObserver2 = false;
  showObserver3 = false;

  constructor(private subjectservice: BehaviorsubjectserviceService) {

  }

  subscribe1() {
    this.subjectservice.count$.subscribe( 
      data => { this.observer1.push(data) },
      null,
      () => { this.showObserver1 = true; }
    )
  }
  susbcribe2() {
    this.subjectservice.count$.subscribe(
      data => { this.observer2.push(data) },
      null,
      () => { this.showObserver2 = true; }
    )
  }
  susbcribe3() {
    this.subjectservice.count$.subscribe(
      data => { this.observer3.push(data) },
      null,
      () => { this.showObserver3 = true; }
    )
  }

  ngOnInit() {

  }
  ngOnDestroy() {
    
  }

}
