import { Component, OnInit } from '@angular/core';

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

  ngOnInit(): void {
  }

}
