import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { AsyncsubjectserviceService } from '../asyncsubjectservice.service';

@Component({
  selector: 'app-asyncsubject',
  templateUrl: './asyncsubject.component.html',
  styleUrls: ['./asyncsubject.component.css']
})
export class AsyncsubjectComponent implements OnInit {

  title = 'Async Subject Demo';
  observer1$: Subscription;
  observer2$: Subscription;
  observer3$: Subscription;
  observer1 = [];
  observer2 = [];
  observer3 = [];
  showObserver1 = false;
  showObserver2 = false;
  showObserver3 = false;

  constructor(private subjectservice: AsyncsubjectserviceService) {

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
