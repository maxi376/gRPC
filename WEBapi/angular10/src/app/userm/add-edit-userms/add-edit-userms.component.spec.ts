import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditUsermsComponent } from './add-edit-userms.component';

describe('AddEditUsermsComponent', () => {
  let component: AddEditUsermsComponent;
  let fixture: ComponentFixture<AddEditUsermsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEditUsermsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditUsermsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
