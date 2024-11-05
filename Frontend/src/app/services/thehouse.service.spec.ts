import { TestBed } from '@angular/core/testing';

import { ThehouseService } from './thehouse.service';

describe('ThehouseService', () => {
  let service: ThehouseService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ThehouseService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
