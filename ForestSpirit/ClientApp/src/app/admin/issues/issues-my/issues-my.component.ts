import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-issues-my',
  templateUrl: './issues-my.component.html',
  styleUrls: ['../../../../styles.css']
})
export class IssuesMyComponent implements OnInit {

  issue1 = new Issue(1, "wniosek_01.12.2022", new Date(), 0, "../../../assets/zdjecie_brak_pionowe.jpg");
  issue2 = new Issue(2, "wniosek_01.12.2022", new Date(), 0, "../../../assets/zdjecie_brak_pionowe.jpg");
  issue3 = new Issue(3, "wniosek_01.12.2022", new Date(), 0, "../../../assets/zdjecie_brak_pionowe.jpg");
  issue4 = new Issue(4, "wniosek_01.12.2022", new Date(), 0, "../../../assets/zdjecie_brak_pionowe.jpg");

  issues = new Array(this.issue1, this.issue2, this.issue3, this.issue4);


  constructor() { }

  ngOnInit(): void {
  }

}



class Issue {
  public id: number;
  public nazwa: string;
  public data: Date = new Date();
  public status: number;
  public picture: string;


  constructor(id:number, nazwa:string, data:Date, status:number, picture: string){
    this.id = id;
    this.nazwa = nazwa;
    this.data = data;
    this.status = status;
    this.picture = picture;
  }

}
