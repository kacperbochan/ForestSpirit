import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['../../../../styles.css']
})



export class CustomersComponent implements OnInit {

  customer1 = new Customer(1, "Kamil Duda", "nowy klient", "woźniakowa 32A, Choroszcz", "../../../assets/zdjecie_brak_pionowe.jpg");
  customer2 = new Customer(2, "Kamil Duda", "nowy klient", "woźniakowa 32A, Choroszcz", "../../../assets/zdjecie_brak_pionowe.jpg");

  customers = new Array(this.customer1, this.customer2);

  constructor() { }



  ngOnInit(): void {
  }

}


class Customer {
  public id: number;
  public nazwa: string;
  public opis: string;
  public adres: string;
  public picture: string;


  constructor(id:number, nazwa:string, opis:string, adres:string, picture: string){
    this.id = id;
    this.nazwa = nazwa;
    this.opis = opis;
    this.adres = adres;
    this.picture = picture;
  }

}
