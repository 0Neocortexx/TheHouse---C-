import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GastosChartsComponent } from './gastos-charts.component';

describe('GastosChartsComponent', () => {
  let component: GastosChartsComponent;
  let fixture: ComponentFixture<GastosChartsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GastosChartsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GastosChartsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
