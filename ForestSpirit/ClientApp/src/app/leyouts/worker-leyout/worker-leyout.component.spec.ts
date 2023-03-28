import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkerLeyoutComponent } from './worker-leyout.component';

describe('WorkerLeyoutComponent', () => {
  let component: WorkerLeyoutComponent;
  let fixture: ComponentFixture<WorkerLeyoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkerLeyoutComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkerLeyoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
