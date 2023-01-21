import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserLeyoutComponent } from './user-leyout.component';

describe('UserLeyoutComponent', () => {
  let component: UserLeyoutComponent;
  let fixture: ComponentFixture<UserLeyoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserLeyoutComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserLeyoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
