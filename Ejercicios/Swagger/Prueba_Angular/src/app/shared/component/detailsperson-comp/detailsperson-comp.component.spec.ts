import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailspersonCompComponent } from './detailsperson-comp.component';

describe('DetailspersonCompComponent', () => {
  let component: DetailspersonCompComponent;
  let fixture: ComponentFixture<DetailspersonCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailspersonCompComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailspersonCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
