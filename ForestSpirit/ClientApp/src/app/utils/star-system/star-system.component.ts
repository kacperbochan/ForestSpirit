import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-star-system',
  templateUrl: './star-system.component.html',
  styleUrls: ['./star-system.component.css']
})
export class StarSystemComponent implements OnInit {

  @Input() score:number;
  title:string;
  constructor() { }


  ngOnInit(): void {
    this.title = this.score/20+"/5";
  }

}
