import { Component, OnInit } from '@angular/core';
import { CarDto } from 'src/app/models/carDto';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css'],
})
export class IndexComponent implements OnInit {
  dataLoaded = false;
  carDto: CarDto[] = [];
  tempCarDto: CarDto[] = [];
  constructor(private carService: CarService) {}

  ngOnInit(): void {
    this.getRandomThreeCarDto();
  }

  getRandomThreeCarDto() {
    this.carService.getCarsDto().subscribe((response) => {
      this.tempCarDto = response.data;
      this.dataLoaded = true;
      if (this.dataLoaded) {
        for (let i = 0; i < 3; i++) {
          let randomItem =
            this.tempCarDto[Math.floor(Math.random() * this.tempCarDto.length)];
          this.carDto.push(randomItem);
          this.tempCarDto = this.tempCarDto.filter((data) => {
            return data !== randomItem;
          });
        }
      }
      console.log(this.carDto);
    });
  }
}
