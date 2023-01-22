import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersNewComponent } from './workers-new.component';

describe('WorkersNewComponent', () => {
  let component: WorkersNewComponent;
  let fixture: ComponentFixture<WorkersNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersNewComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
