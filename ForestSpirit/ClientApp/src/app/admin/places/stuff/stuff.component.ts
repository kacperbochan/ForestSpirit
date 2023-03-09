import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-stuff',
  templateUrl: './stuff.component.html',
  styleUrls: ['./stuff.component.css']
})
export class StuffComponent implements OnInit {
  stuff1 = new Stuff(1, "Sprzęt A", "super fajny sprrzęcik", "../../../assets/zdjecie_brak_pionowe.jpg", 2);
  stuff2 = new Stuff(1, "Sprzęt A", "super fajny sprrzęcik", "../../../assets/zdjecie_brak_pionowe.jpg", 2);
  stuff3 = new Stuff(1, "Sprzęt A", "super fajny sprrzęcik", "../../../assets/zdjecie_brak_pionowe.jpg", 2);
  stuff4 = new Stuff(1, "Sprzęt A", "super fajny sprrzęcik", "../../../assets/zdjecie_brak_pionowe.jpg", 2);

  stuffListed = new Array(this.stuff1, this.stuff2, this.stuff3, this.stuff4);



  constructor() { }

  ngOnInit(): void {
  }

}


class Stuff {
  public id: number;
  public nazwa: string;
  public opis: string;
  public picture: string;
  public idDestylarni: number;


  constructor(id:number, nazwa:string, opis:string, picture: string, idDestylarni: number){
    this.id = id;
    this.nazwa = nazwa;
    this.opis = opis;
    this.picture = picture;
    this.idDestylarni = idDestylarni;
  }

}
