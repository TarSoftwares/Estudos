import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MeuForm2Component } from './meu-form2.component';

describe('MeuForm2Component', () => {
  let component: MeuForm2Component;
  let fixture: ComponentFixture<MeuForm2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MeuForm2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MeuForm2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
