import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GastosYearTimeLineComponent } from './gastos-year-time-line.component';

describe('GastosYearTimeLineComponent', () => {
  let component: GastosYearTimeLineComponent;
  let fixture: ComponentFixture<GastosYearTimeLineComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GastosYearTimeLineComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GastosYearTimeLineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
