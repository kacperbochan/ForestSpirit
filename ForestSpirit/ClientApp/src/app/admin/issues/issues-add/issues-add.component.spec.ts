import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IssuesAddComponent } from './issues-add.component';

describe('IssuesAddComponent', () => {
  let component: IssuesAddComponent;
  let fixture: ComponentFixture<IssuesAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IssuesAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IssuesAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
