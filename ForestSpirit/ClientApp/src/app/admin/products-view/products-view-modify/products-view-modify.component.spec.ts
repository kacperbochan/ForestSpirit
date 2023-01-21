import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductsViewModifyComponent } from './products-view-modify.component';

describe('ProductsViewModifyComponent', () => {
  let component: ProductsViewModifyComponent;
  let fixture: ComponentFixture<ProductsViewModifyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductsViewModifyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductsViewModifyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
