import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IssuesMyComponent } from './issues-my.component';

describe('IssuesMyComponent', () => {
  let component: IssuesMyComponent;
  let fixture: ComponentFixture<IssuesMyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IssuesMyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IssuesMyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
