import { TestBed } from '@angular/core/testing';

import { TheHouseService } from './the-house.service';

describe('TheHouseService', () => {
  let service: TheHouseService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TheHouseService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
