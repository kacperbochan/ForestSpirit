import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersSentComponent } from './workers-sent.component';

describe('WorkersSentComponent', () => {
  let component: WorkersSentComponent;
  let fixture: ComponentFixture<WorkersSentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersSentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersSentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
