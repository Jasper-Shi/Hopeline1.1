import { TestBed } from '@angular/core/testing';

import { AdminResCommService } from './admin-res-comm.service';

describe('AdminResCommService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminResCommService = TestBed.get(AdminResCommService);
    expect(service).toBeTruthy();
  });
});
