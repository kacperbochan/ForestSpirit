import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IssuessentComponent } from './issuessent.component';

describe('IssuessentComponent', () => {
  let component: IssuessentComponent;
  let fixture: ComponentFixture<IssuessentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IssuessentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IssuessentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
