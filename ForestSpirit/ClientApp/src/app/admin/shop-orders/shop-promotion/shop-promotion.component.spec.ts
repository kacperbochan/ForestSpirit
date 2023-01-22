import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShopPromotionComponent } from './shop-promotion.component';

describe('ShopPromotionComponent', () => {
  let component: ShopPromotionComponent;
  let fixture: ComponentFixture<ShopPromotionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShopPromotionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShopPromotionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
