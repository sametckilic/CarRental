import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent implements OnInit {
  cars: Car[] = [];
  dataLoaded = false;
  constructor(
    private carService: CarService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params) => {
      if (params['brandId']) {
        this.getCarsByBrandId(params['brandId']);
      } else if (params['fuelTypeId']) {
        this.getCarsByFuelTypeId(params['fuelTypeId']);
      } else if (params['gearTypeId']) {
        this.getCarsByGearTypeId(params['gearTypeId']);
      } else if (params['colorId']) {
        this.getCarsByColorId(params['colorId']);
      } else {
        this.getCarsDto();
      }
    });
  }

  getCarsDto() {
    this.carService.GetCarsDto().subscribe((response) => {
      this.cars = response.data;
    });
  }

  getCars() {
    this.carService.getCars().subscribe((response) => {
      this.cars = response.data;
      this.dataLoaded = true;
    });
  }
  getCarsByBrandId(brandId: number) {
    this.carService.getCarsByBrandId(brandId).subscribe((response) => {
      this.cars = response.data;
      this.dataLoaded = true;
    });
  }
  getCarsByFuelTypeId(fuelTypeId: number) {
    this.carService.getCarsByFuelTypeId(fuelTypeId).subscribe((response) => {
      this.cars = response.data;
      this.dataLoaded = true;
    });
  }
  getCarsByGearTypeId(gearTypeId: number) {
    this.carService.getCarsByGearTypeId(gearTypeId).subscribe((response) => {
      this.cars = response.data;
    });
  }
  getCarsByColorId(colorTypeId: number) {
    this.carService.getCarsByColorId(colorTypeId).subscribe((response) => {
      this.cars = response.data;
      this.dataLoaded = true;
    });
  }
}
