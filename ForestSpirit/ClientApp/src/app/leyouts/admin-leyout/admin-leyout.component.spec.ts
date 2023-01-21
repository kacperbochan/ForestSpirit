import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminLeyoutComponent } from './admin-leyout.component';

describe('AdminLeyoutComponent', () => {
  let component: AdminLeyoutComponent;
  let fixture: ComponentFixture<AdminLeyoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminLeyoutComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminLeyoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
