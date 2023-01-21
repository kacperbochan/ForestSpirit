import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';

import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ShopComponent } from './shop/shop.component';
import { CartComponent } from './cart/cart.component';
import { CartProductsComponent } from './cart/cart-products/cart-products.component';
import { AdresFormComponent } from './cart/adres-form/adres-form.component';
import { SummaryComponent } from './cart/summary/summary.component'
import { ProductComponent } from './product/product.component';
import { OpinionComponent } from './product/opinion/opinion.component';
import { ProductInfoComponent } from './product/product-info/product-info.component';
import { SimilarProductComponent } from './product/similar-product/similar-product.component';
import { PaymentComponent } from './cart/payment/payment.component';
import { ContactComponent } from './contact/contact.component';
import { ProductListComponent } from './shop/product-list/product-list.component';
import { FooterComponent } from './footer/footer.component';

import { AdminLeyoutComponent } from './leyouts/admin-leyout/admin-leyout.component';
import { AdminNavMenuComponent } from './leyouts/admin-nav-menu/admin-nav-menu.component';
import { UserNavMenuComponent } from './leyouts/user-nav-menu/user-nav-menu.component';
import { UserLeyoutComponent } from './leyouts/user-leyout/user-leyout.component';
import { AdminComponent } from './admin/admin/admin.component';
import { CustomersComponent } from './admin/customers/customers.component';
import { IssuesComponent } from './admin/issues/issues.component';
import { PlacesComponent } from './admin/places/places.component';
import { ShopOrdersComponent } from './admin/shop-orders/shop-orders.component';
import { WorkersComponent } from './admin/workers/workers.component';
import { ProductsViewComponent } from './admin/products-view/products-view.component';


@NgModule({
  declarations: [
    AboutComponent,
    AdresFormComponent,
    AppComponent,
    CartComponent,
    CartProductsComponent,
    FetchDataComponent,
    HomeComponent,
    UserNavMenuComponent,
    FooterComponent,
    ShopComponent,
    ProductComponent,
    PaymentComponent,
    SummaryComponent,
    OpinionComponent,
    ProductInfoComponent,
    SimilarProductComponent,
    ContactComponent,
    ProductListComponent,
    AdminLeyoutComponent,
    AdminNavMenuComponent,
    UserNavMenuComponent,
    UserLeyoutComponent,
    AdminComponent,
    CustomersComponent,
    IssuesComponent,
    PlacesComponent,
    ShopOrdersComponent,
    WorkersComponent,
    ProductsViewComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: UserLeyoutComponent, pathMatch: 'full',
      children: [{path: '', component: HomeComponent}
      ]},
      { path: 'contact', component: UserLeyoutComponent,
      children: [
        {path: '', component: ContactComponent}
      ] },
      { path: 'fetch-data', component: UserLeyoutComponent,
      children: [
        {path: '', component: FetchDataComponent}
      ]},
      { path: 'about', component: UserLeyoutComponent,
      children: [
        {path: '', component: AboutComponent}
      ] },
      { path: 'shop', component: UserLeyoutComponent,
      children: [
        {path: '', component: ShopComponent}
      ] },
      { path: 'cart', component: UserLeyoutComponent,
      children: [
        {path: '', component: CartComponent}
      ] },
      { path: 'product', component: UserLeyoutComponent,
      children: [
        {path: '', component: ProductComponent}
      ] },
      { path: 'footer-test', component: UserLeyoutComponent,
      children: [
        {path: '', component: SummaryComponent}
      ] },
      { path: 'admin', component: AdminLeyoutComponent,
        children: [
          {path: '', component: AdminComponent}
      ] },
      { path: 'workers', component: AdminLeyoutComponent,
      children: [
        {path: '', component: WorkersComponent}
      ] },
      { path: 'customers', component: AdminLeyoutComponent,
      children: [
        {path: '', component: CustomersComponent}
      ] },
      { path: 'issues', component: AdminLeyoutComponent,
      children: [
        {path: '', component: IssuesComponent}
      ] },
      { path: 'products-view', component: AdminLeyoutComponent,
      children: [
        {path: '', component: ProductsViewComponent}
      ] },
      { path: 'places', component: AdminLeyoutComponent,
      children: [
        {path: '', component: PlacesComponent}
      ] },
      { path: 'shop-orders', component: AdminLeyoutComponent,
      children: [
        {path: '', component: ShopOrdersComponent}
      ] },
    ], {scrollPositionRestoration: 'enabled'}),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
