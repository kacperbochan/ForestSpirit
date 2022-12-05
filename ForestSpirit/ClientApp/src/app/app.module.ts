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
import { CartComponent } from './cart/cart.component';
import { AdresFormComponent } from './cart/adres-form/adres-form.component';
import { SummaryComponent } from './cart/summary/summary.component'
import { ProductComponent } from './product/product.component';
import { OpinionComponent } from './product/opinion/opinion.component';
import { ProductInfoComponent } from './product/product-info/product-info.component';
import { SimilarProductComponent } from './product/similar-product/similar-product.component';
import { ContactComponent } from './contact/contact.component';
import { ProductListComponent } from './shop/product-list/product-list.component';
import { FooterComponent } from './footer/footer.component';
import { from } from 'rxjs';

@NgModule({
  declarations: [
    AboutComponent,
    AdresFormComponent,
    AppComponent,
    CartComponent,
    FetchDataComponent,
    HomeComponent,
    NavMenuComponent,
    FooterComponent,
    ShopComponent,
    ProductComponent,
    SummaryComponent,
    OpinionComponent,
    ProductInfoComponent,
    SimilarProductComponent,
    ContactComponent,
    ProductListComponent
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
      { path: 'cart', component: CartComponent },
      { path: 'product', component: ProductComponent },
      { path: 'footer-test', component: SummaryComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
