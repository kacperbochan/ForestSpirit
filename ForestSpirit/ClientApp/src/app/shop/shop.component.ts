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

  constructor() { 
  }
  selected:number=1;
  isMobile: boolean = false;

  ngOnInit(): void {
    this.selected=-1;
    this.isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini|Mobile|mobile|CriOS/i.test(navigator.userAgent)
  }

  selectCategory(category:number){
    this.selected = category;
  }

}
