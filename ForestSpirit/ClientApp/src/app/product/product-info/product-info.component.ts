import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-info',
  templateUrl: './product-info.component.html',
  styleUrls: ['./product-info.component.css']
})
export class ProductInfoComponent implements OnInit {
  smak = new Array("gruszka", "wiśnia", "karmel", "orzech");

  produkt1 = new Produkt("Bimber 1", "dlugi opis produktu", 123, 3.02, "assets/zdjecie_brak_pionowe.jpg", this.smak);


  constructor() { }

  ngOnInit(): void {
  }

}

class Produkt {
  private _nazwa: string;
  private _opis: string;
  private _cena: number;
  private _ocena: number;
  private _zdjecie: string;
  private _smaki: string[];

  constructor(nazwa:string, opis:string, cena:number, ocena:number, zdjecie:string, smaki:string[]){
    this._nazwa = nazwa;
    this._opis = opis;
    this._cena = cena;
    this._ocena = ocena;
    this._zdjecie=zdjecie;
    this._smaki=smaki;
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

  public get cena() : number{
      return this._cena;
  }

  public set cena(theCena: number) {
      this._cena = theCena;
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

  public get smaki() : string[] {
    return this._smaki;
  }

  public set smaki(theSmaki:string[]){
      this._smaki = theSmaki;
  }
}
