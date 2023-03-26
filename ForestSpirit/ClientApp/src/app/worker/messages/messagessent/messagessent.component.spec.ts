import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessagessentComponent } from './messagessent.component';

describe('MessagessentComponent', () => {
  let component: MessagessentComponent;
  let fixture: ComponentFixture<MessagessentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessagessentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MessagessentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
