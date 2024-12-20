import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EntretenimentosComponent } from './entretenimentos.component';

describe('EntretenimentosComponent', () => {
  let component: EntretenimentosComponent;
  let fixture: ComponentFixture<EntretenimentosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EntretenimentosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EntretenimentosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
