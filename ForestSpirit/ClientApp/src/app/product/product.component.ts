import { HttpClient } from '@angular/common/http';
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

  productId:number = -1;

  constructor( private route: ActivatedRoute,private http: HttpClient) {
    this.route.params.subscribe( params=> this.productId = params['id']);
  }

  produkt : Produkt ;



  ngOnInit(): void {
    this.http.get<Produkt_incoming>("http://localhost:5047/api/products/get?key="+this.productId).subscribe(
        x=> this.produkt = new Produkt(
            x.id, x.name,"opipis",x.price,x.rating,x.procentage,"assets/zdjecie_brak_pionowe.jpg")
          )
    };


}
