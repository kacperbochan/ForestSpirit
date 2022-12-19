import { Component, Input, OnInit } from '@angular/core';
import { Produkt } from 'src/types/produkt';
import { Dostawa } from 'src/types/dostawa';
import { orderElem } from 'src/types/order';

@Component({
  selector: 'app-summary',
  templateUrl: './summary.component.html',
  styleUrls: ['./summary.component.css']
})
export class SummaryComponent implements OnInit {

  @Input() produkty:orderElem[];

  public podsumowanie:number=0;
  public dostawa:Dostawa = new Dostawa("kurier",20);
  public suma:number=0;

  constructor() { }

  ngOnInit(): void {
    this.LiczPodsumowanie();
    console.log(this.produkty);
  }

  public LiczPodsumowanie(){
    this.podsumowanie=0;
    this.produkty.forEach((value)=>
      this.podsumowanie+=((value.ilosc>0)?(value.ilosc*value.produkt.cena):0)
    );
    this.suma = this.podsumowanie+this.dostawa.cena;
  }


}

