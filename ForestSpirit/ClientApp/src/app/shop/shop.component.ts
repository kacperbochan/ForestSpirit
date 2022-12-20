import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Produkt } from 'src/Models/produkt';
import { Produkt_incoming } from 'src/Models/produkt_incoming';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.css']
})
export class ShopComponent implements OnInit {

  selected:number=1;

  constructor( ) { }
  ngOnInit(): void {
    this.selected=-1;
  }

  selectCategory(category:number){
    this.selected = category;
  }

}
