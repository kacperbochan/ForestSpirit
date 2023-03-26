import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessagesreceivedComponent } from './messagesreceived.component';

describe('MessagesreceivedComponent', () => {
  let component: MessagesreceivedComponent;
  let fixture: ComponentFixture<MessagesreceivedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessagesreceivedComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MessagesreceivedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
