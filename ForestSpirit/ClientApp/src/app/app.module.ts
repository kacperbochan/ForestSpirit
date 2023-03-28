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
import { StarSystemComponent } from './utils/star-system/star-system.component';
import { FooterComponent } from './footer/footer.component';

import { AdminLeyoutComponent } from './leyouts/admin-leyout/admin-leyout.component';
import { AdminNavMenuComponent } from './leyouts/admin-nav-menu/admin-nav-menu.component';
import { UserNavMenuComponent } from './leyouts/user-nav-menu/user-nav-menu.component';
import { UserLeyoutComponent } from './leyouts/user-leyout/user-leyout.component';
import { AdminComponent } from './admin/admin/admin.component';
import { CustomersComponent } from './admin/customers/customers/customers.component';
import { PlacesComponent } from './admin/places/places/places.component';
import { ShopOrdersComponent } from './admin/shop-orders/shop-orders/shop-orders.component';
import { WorkersAccountComponent } from './admin/workers/workers-account/workers-account.component';
import { WorkersBinComponent } from './admin/workers/workers-bin/workers-bin.component';
import { WorkersModifyComponent } from './admin/workers/workers-modify/workers-modify.component';
import { WorkersNewComponent } from './admin/workers/workers-new/workers-new.component';
import { WorkersReceivedComponent } from './admin/workers/workers-received/workers-received.component';
import { WorkersSentComponent } from './admin/workers/workers-sent/workers-sent.component';
import { WorkersScheduleComponent } from './admin/workers/workers-schedule/workers-schedule.component';
import { CustomersModifyComponent } from './admin/customers/customers-modify/customers-modify.component';
import { IssuesAddComponent } from './admin/issues/issues-add/issues-add.component';
import { IssuesMyComponent } from './admin/issues/issues-my/issues-my.component';
import { IssuesReceivedComponent } from './admin/issues/issues-received/issues-received.component';
import { ProductsViewComponent } from './admin/products-view/products-view/products-view.component';
import { ProductsViewAddComponent } from './admin/products-view/products-view-add/products-view-add.component';
import { ProductsViewModifyComponent } from './admin/products-view/products-view-modify/products-view-modify.component';
import { ShopPromotionComponent } from './admin/shop-orders/shop-promotion/shop-promotion.component';
import { PlacesAddComponent } from './admin/places/places-add/places-add.component';
import { PlacesModifyComponent } from './admin/places/places-modify/places-modify.component';
import { StuffAddComponent } from './admin/places/stuff-add/stuff-add.component';
import { StuffComponent } from './admin/places/stuff/stuff.component';
import { StuffModifyComponent } from './admin/places/stuff-modify/stuff-modify.component';
import { SuppliesComponent } from './admin/places/supplies/supplies.component';
import { SuppliesAddComponent } from './admin/places/supplies-add/supplies-add.component';


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
    StarSystemComponent,
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
    PlacesComponent,
    ShopOrdersComponent,
    WorkersAccountComponent,
    WorkersBinComponent,
    WorkersModifyComponent,
    WorkersNewComponent,
    WorkersReceivedComponent,
    WorkersSentComponent,
    WorkersScheduleComponent,
    CustomersModifyComponent,
    IssuesAddComponent,
    IssuesMyComponent,
    IssuesReceivedComponent,
    ProductsViewComponent,
    ProductsViewAddComponent,
    ProductsViewModifyComponent,
    ShopPromotionComponent,
    PlacesAddComponent,
    PlacesModifyComponent,
    StuffAddComponent,
    StuffComponent,
    StuffModifyComponent,
    SuppliesComponent,
    SuppliesAddComponent
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

      { path: '', component: UserLeyoutComponent,
      children: [
        {path: 'contact', component: ContactComponent},
        {path: 'fetch-data', component: FetchDataComponent},
        {path: 'about', component: AboutComponent},
        {path: 'shop', component: ShopComponent},
        {path: 'cart', component: CartComponent},
        {path: 'product/:id', component: ProductComponent},
        {path: 'footer-test', component: SummaryComponent}
      ] },

      { path: 'admin', component: AdminLeyoutComponent,
        children: [
          {path: '', component: AdminComponent},
          {path: 'workers-account', component: WorkersAccountComponent},
          {path: 'workers-bin', component: WorkersBinComponent},
          {path: 'workers-modify', component: WorkersModifyComponent},
          {path: 'workers-new', component: WorkersNewComponent},
          {path: 'workers-received', component: WorkersReceivedComponent},
          {path: 'workers-schedule', component: WorkersScheduleComponent},
          {path: 'workers-sent', component: WorkersSentComponent},
          {path: 'customers', component: CustomersComponent},
          {path: 'customers-modify', component: CustomersModifyComponent},
          {path: 'issues', component: IssuesMyComponent},
          {path: 'issues-add', component: IssuesAddComponent},
          {path: 'issues-received', component: IssuesReceivedComponent},
          {path: 'products-view', component: ProductsViewComponent},
          {path: 'products-view-add', component: ProductsViewAddComponent},
          {path: 'products-view-modify', component: ProductsViewModifyComponent},
          {path: 'places', component: PlacesComponent},
          {path: 'places-add', component: PlacesAddComponent},
          {path: 'places-modify', component: PlacesModifyComponent},
          {path: 'stuff', component: StuffComponent},
          {path: 'stuff-add', component: StuffAddComponent},
          {path: 'stuff-modify', component: StuffModifyComponent},
          {path: 'supplies', component: SuppliesComponent},
          {path: 'supplies-add', component: SuppliesAddComponent},
          {path: 'shop-orders', component: ShopOrdersComponent},
          {path: 'shop-promotions', component: ShopPromotionComponent}
      ] },




    ], {scrollPositionRestoration: 'enabled'}),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
