import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-workers-account',
  templateUrl: './workers-account.component.html',
  styleUrls: ['../../../../styles.css']
})
export class WorkersAccountComponent implements OnInit {
  worker1 = new Worker( 1, "Kamil Duda", "kierownik przerzucania gnoju", "../../../assets/zdjecie_brak_pionowe.jpg", 2);
  worker2 = new Worker( 2, "Kamil Duda", "kierownik przerzucania gnoju", "../../../assets/zdjecie_brak_pionowe.jpg",2);
  worker3 = new Worker( 3, "Kamil Duda", "kierownik przerzucania gnoju", "../../../assets/zdjecie_brak_pionowe.jpg",2);

  workerListed = new Array(this.worker1, this.worker2, this.worker3);

  constructor() { }

  ngOnInit(): void {
  }

}


class Worker {
  public id: number;
  public nazwa: string;
  public stanowisko: string;
  public zdjecie: string;
  public idDestylarni: number;


  constructor(id:number, nazwa:string, stanowisko:string, zdjecie: string, idDestylarni: number  ){
    this.id = id;
    this.nazwa = nazwa;
    this.stanowisko = stanowisko;
    this.zdjecie = zdjecie;
    this.idDestylarni = idDestylarni;
  }
}
