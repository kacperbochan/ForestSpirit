import { Component, Input, OnInit } from '@angular/core';
import { orderElem } from 'src/Models/order';
import { Produkt } from 'src/Models/produkt';

@Component({
  selector: 'app-cart-products',
  templateUrl: './cart-products.component.html',
  styleUrls: ['./cart-products.component.css']
})
export class CartProductsComponent implements OnInit {

  @Input() produkty:orderElem[];

  constructor() { }

  ngOnInit(): void {}



}
