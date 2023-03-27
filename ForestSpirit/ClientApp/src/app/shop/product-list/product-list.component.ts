import { Component, Input, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Produkt_incoming } from 'src/Models/produkt_incoming';
import { Produkt } from 'src/Models/produkt';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

 @Input() selected: number=1;
 @Input() isMobile: boolean = false;

  // produkt1 = new Produkt("Bimber 1", "dlugi opis produktu", 123, 3.02, "assets/zdjecie_brak_pionowe.jpg");
  // produkt2 = new Produkt("Bimber 2", "dlugi opis produktu", 323, 3.21, "assets/zdjecie_brak_pionowe.jpg");
  // produkt3 = new Produkt("Bimber 3", "dlugi opis produktu", 232, 4.77, "assets/zdjecie_brak_pionowe.jpg");
  // produkt4 = new Produkt("Bimber 4", "dlugi opis produktu", 99.00, 4.64, "assets/zdjecie_brak_pionowe.jpg");



   produkty : Produkt[] = new Array<Produkt>() ;
   produktyListed: Produkt[] = new Array<Produkt>();

  constructor( private http: HttpClient) { }

  ngOnChanges() {
    switch(this.selected){
      case 0:
        this.produktyListed = this.produkty;
      break;
      case 1:
          this.produktyListed = this.produkty.filter(p=>p.percent>0);
      break;
      case 2:
        this.produktyListed = this.produkty.filter(p=>p.percent==0);
      break;
      case 3:
        this.produktyListed = new Array<Produkt>();
      break;
      case 4:
        this.produktyListed = new Array<Produkt>();
      break;
      default:
        this.produktyListed = new Array<Produkt>();
      break;
    }
  }

  ngOnInit(): void {
    this.http.get<Produkt_incoming[]>("http://localhost:5047/api/products/list").subscribe(data=>{
      data.map(
        x=> {this.produkty.push(
          new Produkt(
            x.id, x.name,"opipis",x.price,x.rating,x.procentage,"assets/zdjecie_brak_pionowe.jpg"))})
    });

    this.produktyListed = this.produkty.filter(p=>p.percent>0);
  }

}

