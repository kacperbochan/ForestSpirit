import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuppliesAddComponent } from './supplies-add.component';

describe('SuppliesAddComponent', () => {
  let component: SuppliesAddComponent;
  let fixture: ComponentFixture<SuppliesAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SuppliesAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SuppliesAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
