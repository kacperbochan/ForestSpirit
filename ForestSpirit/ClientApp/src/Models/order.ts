import { Produkt } from "./produkt";

export class orderElem{
  private _produkt:Produkt;
  private _ilosc:number;

  constructor(produkt:Produkt, ilosc:number){
    this._produkt = produkt;
    this._ilosc = ilosc;
  }

  public get produkt(): Produkt{
    return this._produkt;
  }
  public set produkt(produkt:Produkt){
    this._produkt = produkt;
  }
  public get ilosc(): number{
    return this._ilosc;
  }
  public set ilosc(ilosc:number){
    this._ilosc = ilosc;
  }

}
