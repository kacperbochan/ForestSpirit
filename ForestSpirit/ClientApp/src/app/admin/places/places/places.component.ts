import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-places',
  templateUrl: './places.component.html',
  styleUrls: ['./places.component.css']
})
export class PlacesComponent implements OnInit {

  place1 = new Place(1, "Destylarnia Choroska", "69.696969N 69.696969E", "../../../assets/zdjecie_brak_pionowe.jpg");
  place2 = new Place(2, "Destylarnia Choroska", "69.696969N 69.696969E", "../../../assets/zdjecie_brak_pionowe.jpg");
  place3 = new Place(3, "Destylarnia Choroska", "69.696969N 69.696969E", "../../../assets/zdjecie_brak_pionowe.jpg");
  place4 = new Place(4, "Destylarnia Choroska", "69.696969N 69.696969E", "../../../assets/zdjecie_brak_pionowe.jpg");

  places = new Array(this.place1, this.place2, this.place3, this.place4);

  constructor() { }

  ngOnInit(): void {
  }

}


class Place {
  public id: number;
  public nazwa: string;
  public adres: string;
  public picture: string;


  constructor(id:number, nazwa:string, adres:string, picture: string){
    this.id = id;
    this.nazwa = nazwa;
    this.adres = adres;
    this.picture = picture;
  }

}
