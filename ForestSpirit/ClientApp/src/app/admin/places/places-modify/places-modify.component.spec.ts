import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlacesModifyComponent } from './places-modify.component';

describe('PlacesModifyComponent', () => {
  let component: PlacesModifyComponent;
  let fixture: ComponentFixture<PlacesModifyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PlacesModifyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PlacesModifyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
