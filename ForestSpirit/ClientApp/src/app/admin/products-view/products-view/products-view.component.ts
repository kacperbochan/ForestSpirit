import { Component, OnInit } from '@angular/core';
import { Produkt } from 'src/Models/produkt';
import { HttpClient } from '@angular/common/http';
import { Produkt_incoming } from 'src/Models/produkt_incoming';



@Component({
  selector: 'app-products-view',
  templateUrl: './products-view.component.html',
  styleUrls: ['../../../../styles.css']
})
export class ProductsViewComponent implements OnInit {

  produkty : Produkt[] = new Array<Produkt>() ;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get<Produkt_incoming[]>("http://localhost:5047/api/products/list").subscribe(data=>{
      data.map(
        x=> {this.produkty.push(
          new Produkt(
            x.id, x.name,"opipis",x.price,x.rating,x.procentage,"assets/zdjecie_brak_pionowe.jpg"))})
    });
  }

}
