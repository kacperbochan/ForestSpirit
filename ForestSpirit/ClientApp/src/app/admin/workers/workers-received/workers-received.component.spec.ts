import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersReceivedComponent } from './workers-received.component';

describe('WorkersReceivedComponent', () => {
  let component: WorkersReceivedComponent;
  let fixture: ComponentFixture<WorkersReceivedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersReceivedComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersReceivedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
