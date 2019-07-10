import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceListManageComponent } from './resource-list-manage.component';

describe('ResourceListManageComponent', () => {
  let component: ResourceListManageComponent;
  let fixture: ComponentFixture<ResourceListManageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceListManageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceListManageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
