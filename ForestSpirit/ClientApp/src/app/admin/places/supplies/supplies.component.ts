import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-supplies',
  templateUrl: './supplies.component.html',
  styleUrls: ['./supplies.component.css']
})
export class SuppliesComponent implements OnInit {

  supplies1 = new Supplies(1, "Wiśnie", 1000, new Date() ,"../../../assets/zdjecie_brak_pionowe.jpg", 2);
  supplies2 = new Supplies(2, "Wiśnie", 333, new Date() ,"../../../assets/zdjecie_brak_pionowe.jpg", 2);
  supplies3 = new Supplies(3, "Wiśnie", 2137, new Date() ,"../../../assets/zdjecie_brak_pionowe.jpg", 2);
  supplies4 = new Supplies(4, "Wiśnie", 2137, new Date() ,"../../../assets/zdjecie_brak_pionowe.jpg", 5);

  suppliesListed = new Array(this.supplies1, this.supplies2, this.supplies3, this.supplies4);

  constructor() { }

  ngOnInit(): void {
  }

}

class Supplies {
  public id: number;
  public nazwa: string;
  public ilosc: number;
  public data: Date = new Date();
  public picture: string;
  public idDestylarni: number;


  constructor(id:number, nazwa:string, ilosc:number, data: Date, picture: string, idDestylarni:number){
    this.id = id;
    this.nazwa = nazwa;
    this.ilosc = ilosc;
    this.data = data;
    this.picture = picture;
    this.idDestylarni = idDestylarni;
  }
}
