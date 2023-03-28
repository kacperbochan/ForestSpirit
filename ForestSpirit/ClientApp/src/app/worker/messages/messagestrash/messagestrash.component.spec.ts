import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessagestrashComponent } from './messagestrash.component';

describe('MessagestrashComponent', () => {
  let component: MessagestrashComponent;
  let fixture: ComponentFixture<MessagestrashComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessagestrashComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MessagestrashComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
