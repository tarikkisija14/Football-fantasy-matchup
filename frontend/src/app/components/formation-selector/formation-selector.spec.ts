import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormationSelector } from './formation-selector';

describe('FormationSelector', () => {
  let component: FormationSelector;
  let fixture: ComponentFixture<FormationSelector>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormationSelector]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormationSelector);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
