import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Produkt } from 'src/Models/produkt';
import { Produkt_incoming } from 'src/Models/produkt_incoming';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
