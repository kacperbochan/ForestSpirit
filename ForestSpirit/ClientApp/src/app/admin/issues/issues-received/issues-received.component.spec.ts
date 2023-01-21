import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IssuesReceivedComponent } from './issues-received.component';

describe('IssuesReceivedComponent', () => {
  let component: IssuesReceivedComponent;
  let fixture: ComponentFixture<IssuesReceivedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IssuesReceivedComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IssuesReceivedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
