export  class Produkt {
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
