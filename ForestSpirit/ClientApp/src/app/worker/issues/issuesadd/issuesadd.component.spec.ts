import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IssuesaddComponent } from './issuesadd.component';

describe('IssuesaddComponent', () => {
  let component: IssuesaddComponent;
  let fixture: ComponentFixture<IssuesaddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IssuesaddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IssuesaddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
