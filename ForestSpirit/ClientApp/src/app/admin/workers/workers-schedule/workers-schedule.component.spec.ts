import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersScheduleComponent } from './workers-schedule.component';

describe('WorkersScheduleComponent', () => {
  let component: WorkersScheduleComponent;
  let fixture: ComponentFixture<WorkersScheduleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersScheduleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
