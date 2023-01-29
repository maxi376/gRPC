import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowUsermsComponent } from './show-userms.component';

describe('ShowUsermsComponent', () => {
  let component: ShowUsermsComponent;
  let fixture: ComponentFixture<ShowUsermsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowUsermsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowUsermsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
