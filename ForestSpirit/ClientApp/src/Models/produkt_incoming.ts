export class Produkt_incoming {
  private _id: number;
  private _name: string;
  private _procentage: number;
  private _price: number;
  private _ingridience: string[];
  private _rating: number;
  private _opinionCount: number;

  constructor(id: number, name:string, percentage:number, price:number, ingredients:string[], rating:number, opinionCount: number){
    this._id = id;
    this._name = name;
    this._procentage = percentage;
    this._price = price;
    this._ingridience = ingredients;
    this._rating = rating;
    this._opinionCount = opinionCount;
  }


  public get id() : number {
    return this._id;
  }

  public set id(theId:number){
      this._id = theId;
  }

  public get name() : string {
      return this._name;
  }

  public set name(name:string){
      this._name = name;
  }

  public get procentage() : number{
      return this._procentage;
  }

  public set procentage(procentage: number) {
      this._procentage = procentage;
  }

  public get price() : number {
    return this._price;
  }

  public set price(price:number){
      this._price = price;
  }

  public get ingridience() : string[] {
    return this._ingridience;
  }

  public set ingridience(ingridience:string[]){
      this._ingridience = ingridience;
  }

  public get rating() : number{
    return this._rating;
  }

  public set rating(rating: number) {
      this._rating = rating;
  }

  public get opinionCount() : number{
    return this._opinionCount;
  }

  public set opinionCount(opinionCount: number) {
      this._opinionCount = opinionCount;
  }
}
