import { TestBed } from '@angular/core/testing';

import { ReplaysubjectserviceService } from './replaysubjectservice.service';

describe('ReplaysubjectserviceService', () => {
  let service: ReplaysubjectserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ReplaysubjectserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
