import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarComponent } from './components/car/car.component';
import { NaviComponent } from './components/navi/navi.component';
import { HttpClientModule } from '@angular/common/http';
import { VatAddedPipe } from './pipes/vat-added.pipe';
import { IndexComponent } from './components/index/index.component';
import { FooterComponent } from './components/footer/footer.component';
import { SingleCarComponent } from './components/single-car/single-car.component';
import { ErrorComponent } from './components/error/error.component';
import { YenicompComponent } from './components/yenicomp/yenicomp.component';

@NgModule({
  declarations: [
    AppComponent,
    CarComponent,
    NaviComponent,
    VatAddedPipe,
    IndexComponent,
    FooterComponent,
    SingleCarComponent,
    ErrorComponent,
    YenicompComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
