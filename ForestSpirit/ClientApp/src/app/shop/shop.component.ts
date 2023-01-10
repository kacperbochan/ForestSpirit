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
    document.body.style.backgroundImage =  "url('../../assets/foggy-pine-forest-background-vector.jpg')";
    document.body.style.backgroundPosition = "center";
    document.body.style.backgroundRepeat = "no repeat";
    document.body.style.backgroundAttachment = "fixed";
    document.body.style.backgroundSize = "cover"; 
  }
  selected:number=1;

  ngOnInit(): void {
    this.selected=-1;
  }

  selectCategory(category:number){
    this.selected = category;
  }

}
