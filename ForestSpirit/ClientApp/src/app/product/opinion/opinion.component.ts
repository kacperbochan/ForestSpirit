import { Component, OnInit } from '@angular/core';
import { Opinia } from 'src/Models/opinia';

@Component({
  selector: 'app-opinion',
  templateUrl: './opinion.component.html',
  styleUrls: ['./opinion.component.css']
})
export class OpinionComponent implements OnInit {
  date1 = new Date('December 17, 1995 03:24:00');

  opinia1 = new Opinia("Maja", "dluga opinia na temat produktu dluga opinia na temat produktu dluga opinia na temat produktu dluga opinia na temat produktudluga opinia na temat produktudluga opinia na temat produktudluga opinia na temat produktudluga opinia na temat produktudluga opinia na temat produktudluga opinia na temat produktu", this.date1, 20, "assets/zdjecie_brak_pionowe.jpg");
  opinia2 = new Opinia("Bartek", "dluga opinia na temat produktu", this.date1, 40, "assets/zdjecie_brak_pionowe.jpg");
  opinia3 = new Opinia("Wojciech", "dluga opinia na temat produktu", this.date1, 80, "assets/zdjecie_brak_pionowe.jpg");

  opinie = new Array(this.opinia1,this.opinia2,this.opinia3);

  constructor() { }

  ngOnInit(): void {
  }

}


