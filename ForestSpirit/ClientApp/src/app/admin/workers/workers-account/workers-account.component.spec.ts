import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkersAccountComponent } from './workers-account.component';

describe('WorkersAccountComponent', () => {
  let component: WorkersAccountComponent;
  let fixture: ComponentFixture<WorkersAccountComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkersAccountComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WorkersAccountComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
