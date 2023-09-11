import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FuelType } from 'src/app/models/fuelType';
import { FuelTypeService } from 'src/app/services/fuel-type.service';

@Component({
  selector: 'app-fuel-type',
  templateUrl: './fuel-type.component.html',
  styleUrls: ['./fuel-type.component.css'],
})
export class FuelTypeComponent implements OnInit {
  fuelTypes: FuelType[] = [];
  dataLoaded = false;
  constructor(private fuelTypeService: FuelTypeService) {}

  ngOnInit(): void {
    this.getFuelTypes();
  }

  getFuelTypes() {
    this.fuelTypeService.getFuelTypes().subscribe((response) => {
      this.fuelTypes = response.data;
      this.dataLoaded = true;
    });
  }
}
