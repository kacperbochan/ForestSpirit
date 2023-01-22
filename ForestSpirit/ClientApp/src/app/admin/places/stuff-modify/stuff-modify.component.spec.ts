import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StuffModifyComponent } from './stuff-modify.component';

describe('StuffModifyComponent', () => {
  let component: StuffModifyComponent;
  let fixture: ComponentFixture<StuffModifyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StuffModifyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StuffModifyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
