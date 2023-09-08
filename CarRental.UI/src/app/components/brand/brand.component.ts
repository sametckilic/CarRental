import { Component, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { BrandService } from 'src/app/services/brand.service';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.css'],
})
export class BrandComponent implements OnInit {
  brands: Brand[] = [];
  currentBrand: number;
  dataLoaded = false;
  isActive: boolean = false;

  constructor(private brandService: BrandService) {}
  ngOnInit(): void {
    this.setAllBrandClass();
    this.setAllBrand();
    this.brandService.getBrands().subscribe((response) => {
      this.brands = response.data;
      this.dataLoaded = true;
    });
  }

  setCurrentBrand(brand: Brand) {
    this.currentBrand = brand.id;
  }

  getCurrentBrandClass(brand: Brand) {
    if (brand.id == this.currentBrand) {
      return 'list-group-item active';
    }
    return 'list-group-item';
  }

  getAllBrandClass() {
    if (!this.currentBrand) {
      return 'list-group-item active';
    }
    return 'list-group-item';
  }

  setAllBrand() {
    this.currentBrand = 0;
  }

  setAllBrandClass() {
    if (this.currentBrand == 0) {
      return 'list-group-item active';
    }
    return 'list-group-item';
  }
}
