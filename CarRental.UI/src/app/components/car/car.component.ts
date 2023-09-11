import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarDto } from 'src/app/models/carDto';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent implements OnInit {
  cars: Car[] = [];
  carsDtos: CarDto[] = [];
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

  getCars() {
    this.carService.getCars().subscribe((response) => {
      this.cars = response.data;
      this.dataLoaded = true;
    });
  }

  getCarsDto() {
    this.carService.getCarsDto().subscribe((response) => {
      this.carsDtos = response.data;
      this.dataLoaded = true;
    });
  }
  getCarDtoById(id: number) {
    this.carService.getCarDtoById(id).subscribe((response) => {
      console.log(response.data);
      return response.data;
    });
  }

  getCarsByBrandId = (brandId: number) => {
    this.carService.getCarsByBrandId(brandId).subscribe((response) => {
      response.data.map((data) => {
        console.log(this.getCarDtoById(data.id));
      });
      this.dataLoaded = true;
    });
  };
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
