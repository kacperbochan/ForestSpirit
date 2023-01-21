import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersModifyComponent } from './workers-modify.component';

describe('WorkersModifyComponent', () => {
  let component: WorkersModifyComponent;
  let fixture: ComponentFixture<WorkersModifyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersModifyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersModifyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
