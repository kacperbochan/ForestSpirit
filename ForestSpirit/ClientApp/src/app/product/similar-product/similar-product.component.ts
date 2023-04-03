import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-similar-product',
  templateUrl: './similar-product.component.html',
  styleUrls: ['./similar-product.component.css']
})
export class SimilarProductComponent implements OnInit {

  produkt1 = new Produkt("Bimber 1", "dlugi opis produktu", 123, 3.02, "assets/products/Alcohol_(116).png");
  produkt2 = new Produkt("Bimber 2", "dlugi opis produktu", 323, 3.21, "assets/products/Alcohol_(133).png");
  produkt3 = new Produkt("Bimber 3", "dlugi opis produktu", 232, 4.77, "assets/products/Alcohol_(126).png");

  produkty = new Array(this.produkt1,this.produkt2,this.produkt3);

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
