import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceCategoryManageComponent } from './resource-category-manage.component';

describe('ResourceCategoryManageComponent', () => {
  let component: ResourceCategoryManageComponent;
  let fixture: ComponentFixture<ResourceCategoryManageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceCategoryManageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceCategoryManageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
