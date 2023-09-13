import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarDto } from 'src/app/models/carDto';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: [],
})
export class CarComponent implements OnInit {
  cars: Car[] = [];
  carsDtos: CarDto[] = [];
  dataLoaded = false;
  constructor(
    private carService: CarService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {}

  getCars() {
    this.dataLoaded = false;

    this.carService.getCars().subscribe((response) => {
      this.cars = response.data;
      this.dataLoaded = true;
    });
  }

  getCarsDto() {
    this.dataLoaded = false;

    this.carService.getCarsDto().subscribe((response) => {
      this.carsDtos = response.data;
      this.dataLoaded = true;
    });
  }

  getCarsByBrandId(brandId: number) {
    this.dataLoaded = false;

    this.carService.getAllDetailsByBrandId(brandId).subscribe((response) => {
      this.carsDtos = response.data;
      this.dataLoaded = true;
    });
  }
  getCarsByFuelTypeId(fuelTypeId: number) {
    this.dataLoaded = false;

    this.carService
      .getAllDetailsByFuelTypeId(fuelTypeId)
      .subscribe((response) => {
        if (response.success) {
          this.carsDtos = response.data;
          this.dataLoaded = true;
        } else {
          this.carsDtos = [];
        }
      });
  }
  getCarsByGearTypeId(gearTypeId: number) {
    this.dataLoaded = false;

    this.carService
      .getAllDetailsByGearTypeId(gearTypeId)
      .subscribe((response) => {
        this.carsDtos = response.data;
        this.dataLoaded = true;
      });
  }
  getCarsByColorId(colorTypeId: number) {
    this.dataLoaded = false;

    this.carService
      .getAllDetailsByColorId(colorTypeId)
      .subscribe((response) => {
        if (response.success) {
          this.carsDtos = response.data;
          this.dataLoaded = true;
        }
      });
  }
}
