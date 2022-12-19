import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-opinion',
  templateUrl: './opinion.component.html',
  styleUrls: ['./opinion.component.css']
})
export class OpinionComponent implements OnInit {
  date1 = new Date('December 17, 1995 03:24:00');

  opinia1 = new Opinia("Maja", "dluga opinia na temat produktu", this.date1, 3.02, "assets/zdjecie_brak_pionowe.jpg");
  opinia2 = new Opinia("Bartek", "dluga opinia na temat produktu", this.date1, 3.21, "assets/zdjecie_brak_pionowe.jpg");
  opinia3 = new Opinia("Wojciech", "dluga opinia na temat produktu", this.date1, 4.77, "assets/zdjecie_brak_pionowe.jpg");

  opinie = new Array(this.opinia1,this.opinia2,this.opinia3);

  constructor() { }

  ngOnInit(): void {
  }

}


class Opinia {
  private _nazwa: string;
  private _opis: string;
  private _data: Date;
  private _ocena: number;
  private _zdjecie: string;

  constructor(nazwa:string, opis:string, data: Date, ocena:number, zdjecie:string){
    this._nazwa = nazwa;
    this._opis = opis;
    this._data = data;
    this._ocena = ocena;
    this._zdjecie=zdjecie;
  }



  public get nazwa() : string {
      return this._nazwa;
  }

  public set nazwa(theNazwa:string){
      this._nazwa = theNazwa;
  }

  public get opis() : string {
      return this._opis;
  }

  public set opis(theOpis:string){
      this._opis = theOpis;
  }

  public get data() : Date{
      return this._data;
  }

  public set data(theData: Date) {
      this._data = theData;
  }

  public get ocena() : number {
    return this._ocena;
  }

  public set ocena(theOcena:number){
      this._ocena = theOcena;
  }

  public get zdjecie() : string {
    return this._zdjecie;
  }

  public set zdjecie(theZdjecie:string){
      this._zdjecie = theZdjecie;
  }
}
