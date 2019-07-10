import { TestBed } from '@angular/core/testing';

import { ResCommServiceService } from './res-comm-service.service';

describe('ResCommServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ResCommServiceService = TestBed.get(ResCommServiceService);
    expect(service).toBeTruthy();
  });
});
