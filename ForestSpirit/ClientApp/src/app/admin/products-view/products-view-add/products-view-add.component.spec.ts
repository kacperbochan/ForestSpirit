import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductsViewAddComponent } from './products-view-add.component';

describe('ProductsViewAddComponent', () => {
  let component: ProductsViewAddComponent;
  let fixture: ComponentFixture<ProductsViewAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductsViewAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductsViewAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
