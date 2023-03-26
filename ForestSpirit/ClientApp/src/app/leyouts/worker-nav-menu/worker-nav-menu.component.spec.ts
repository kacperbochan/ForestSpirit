import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkerNavMenuComponent } from './worker-nav-menu.component';

describe('WorkerNavMenuComponent', () => {
  let component: WorkerNavMenuComponent;
  let fixture: ComponentFixture<WorkerNavMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkerNavMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkerNavMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
