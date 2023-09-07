import { Component } from '@angular/core';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent {
  car1 = {
    carId: 1,
    brandName: 'Mercedes',
    modelName: 'E250',
    price: 500,
  };
  car2 = {
    carId: 2,
    brandName: 'Fiat',
    modelName: 'Egea',
    price: 200,
  };
  car3 = {
    carId: 3,
    brandName: 'Tesla',
    modelName: 'Model Y',
    price: 450,
  };

  cars = [this.car1, this.car2, this.car3];
}
