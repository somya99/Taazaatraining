import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyglobalerrorComponent } from './myglobalerror.component';

describe('MyglobalerrorComponent', () => {
  let component: MyglobalerrorComponent;
  let fixture: ComponentFixture<MyglobalerrorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MyglobalerrorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MyglobalerrorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
