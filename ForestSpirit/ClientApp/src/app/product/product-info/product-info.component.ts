import { Component, Input, OnInit } from '@angular/core';
import { Produkt } from 'src/Models/produkt';

@Component({
  selector: 'app-product-info',
  templateUrl: './product-info.component.html',
  styleUrls: ['./product-info.component.css']
})
export class ProductInfoComponent implements OnInit {
  @Input() produkt: Produkt;

  smak = new Array("gruszka", "wiśnia", "karmel", "orzech");




  constructor() { }

  ngOnInit(): void {
  }

}
