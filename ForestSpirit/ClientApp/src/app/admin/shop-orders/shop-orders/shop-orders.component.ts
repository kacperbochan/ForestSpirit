import { Component, OnInit } from '@angular/core';
import { Produkt } from 'src/Models/produkt';
import { orderElem } from 'src/Models/order';

@Component({
  selector: 'app-shop-orders',
  templateUrl: './shop-orders.component.html',
  styleUrls: ['../../../../styles.css']
})
export class ShopOrdersComponent implements OnInit {

  produkt1 = new Produkt(1, "Bimber 1", "dlugi opis produktu", 123, 3.02,  20, "assets/zdjecie_brak_pionowe.jpg");
  produkt2 = new Produkt(2, "Bimber 2", "dlugi opis produktu", 323, 3.21, 13,  "assets/zdjecie_brak_pionowe.jpg");
  orderElem1 = new orderElem(this.produkt1, 3);
  orderElem2 = new orderElem(this.produkt2, 5);

  orderElemListed = new Array(this.orderElem1, this.orderElem2);

  order1 = new Order( 1, 33, "super długi adres", new Date(), this.orderElemListed);
  order2 = new Order( 2, 22, "super długi adres", new Date(), this.orderElemListed);
  order3 = new Order( 3, 44, "super długi adres", new Date(), this.orderElemListed);

  orderListed = new Array(this.order1, this.order2, this.order3);

  constructor() { }

  ngOnInit(): void {
  }

}



class Order {
  public id: number;
  public cena: number;
  public adres: string;
  public data: Date = new Date();
  public produkty: Array<orderElem>;


  constructor(id:number, cena:number, adres:string, data: Date,  produkty:Array<orderElem> ){
    this.id = id;
    this.cena = cena;
    this.adres = adres;
    this.data = data;
    this.produkty = produkty;
  }
}
