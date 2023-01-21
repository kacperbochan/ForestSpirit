import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomersModifyComponent } from './customers-modify.component';

describe('CustomersModifyComponent', () => {
  let component: CustomersModifyComponent;
  let fixture: ComponentFixture<CustomersModifyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomersModifyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomersModifyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
