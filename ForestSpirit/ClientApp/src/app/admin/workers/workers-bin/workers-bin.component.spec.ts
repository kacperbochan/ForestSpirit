import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersBinComponent } from './workers-bin.component';

describe('WorkersBinComponent', () => {
  let component: WorkersBinComponent;
  let fixture: ComponentFixture<WorkersBinComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersBinComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersBinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
