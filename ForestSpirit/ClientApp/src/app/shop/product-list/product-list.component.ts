import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {


  produkt1 = new Produkt("Bimber 1", "dlugi opis produktu", 123, 3.02, "assets/zdjecie_brak_pionowe.jpg");
  produkt2 = new Produkt("Bimber 2", "dlugi opis produktu", 323, 3.21, "assets/zdjecie_brak_pionowe.jpg");
  produkt3 = new Produkt("Bimber 3", "dlugi opis produktu", 232, 4.77, "assets/zdjecie_brak_pionowe.jpg");
  produkt4 = new Produkt("Bimber 4", "dlugi opis produktu", 99.00, 4.64, "assets/zdjecie_brak_pionowe.jpg");

  produkty = new Array(this.produkt1,this.produkt2,this.produkt3,this.produkt4);

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

  constructor(nazwa:string, opis:string, cena:number, ocena:number, zdjecie:string){
    this._nazwa = nazwa;
    this._opis = opis;
    this._cena = cena;
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
}
