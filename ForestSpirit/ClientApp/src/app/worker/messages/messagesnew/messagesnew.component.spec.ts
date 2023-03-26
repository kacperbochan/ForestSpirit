import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessagesnewComponent } from './messagesnew.component';

describe('MessagesnewComponent', () => {
  let component: MessagesnewComponent;
  let fixture: ComponentFixture<MessagesnewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessagesnewComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MessagesnewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
