export class Dostawa {
  private _nazwa: string;
  private _cena: number;

  constructor(nazwa:string, cena:number){
    this._nazwa = nazwa;
    this._cena = cena;
  }

  public get nazwa() : string {
    return this._nazwa;
  }

  public set nazwa(theNazwa:string){
      this._nazwa = theNazwa;
  }

  public get cena() : number{
    return this._cena;
  }

  public set cena(theCena: number) {
      this._cena = theCena;
  }
}
