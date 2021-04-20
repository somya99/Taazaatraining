import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExitappComponent } from './exitapp.component';

describe('ExitappComponent', () => {
  let component: ExitappComponent;
  let fixture: ComponentFixture<ExitappComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExitappComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExitappComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
