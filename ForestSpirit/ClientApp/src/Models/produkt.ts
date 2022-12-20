
export class Produkt {
  private _id: number;
  private _nazwa: string;
  private _opis: string;
  private _cena: number;
  private _ocena: number;
  private _percent: number;
  private _zdjecie: string;
  private _opinionCount: number;

  constructor(id:number, nazwa:string, opis:string, cena:number, ocena:number, percent:number, zdjecie:string, opinionCount: number=0){
    this._id = id;
    this._nazwa = nazwa;
    this._opis = opis;
    this._cena = cena;
    this._ocena = ocena;
    this._percent = percent;
    this._zdjecie = zdjecie;
    this._opinionCount = opinionCount;
  }

  public get id() : number {
    return this._id;
  }

  public set id(theId:number){
      this._id = theId;
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

  public get percent() : number {
    return this._percent;
  }

  public set percent(thePercent:number){
      this._percent = thePercent;
  }

  public get zdjecie() : string {
    return this._zdjecie;
  }

  public set zdjecie(theZdjecie:string){
      this._zdjecie = theZdjecie;
  }

  public get opinionCount() : number {
    return this._opinionCount;
  }

  public set opinionCount(theCount:number){
      this._opinionCount = theCount;
  }
}
