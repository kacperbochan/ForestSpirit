import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ShopComponent } from './shop/shop.component';
import { BasketComponent } from './basket/basket.component';
import { AdresFormComponent } from './basket/adres-form/adres-form.component';
import { SummaryComponent } from './basket/summary/summary.component'
import { ProductComponent } from './product/product.component';
import { ProductListComponent } from './shop/product-list/product-list.component';
import { OpinionComponent } from './product/opinion/opinion.component';
import { ProductInfoComponent } from './product/product-info/product-info.component';
import { SimilarProductComponent } from './product/similar-product/similar-product.component';
import { ContactComponent } from './contact/contact.component';

@NgModule({
  declarations: [
    AboutComponent,
    AdresFormComponent,
    AppComponent,
    BasketComponent,
    FetchDataComponent,
    HomeComponent,
    NavMenuComponent,
    ShopComponent,
    ProductComponent,
    SummaryComponent,
    ProductListComponent,
    OpinionComponent,
    ProductInfoComponent,
    SimilarProductComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'contact', component: ContactComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'about', component: AboutComponent },
      { path: 'shop', component: ShopComponent },
      { path: 'basket', component: BasketComponent },
      { path: 'product', component: ProductComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
