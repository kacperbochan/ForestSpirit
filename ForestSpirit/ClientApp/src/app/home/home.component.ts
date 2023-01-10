import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{

  constructor() { 
    document.body.style.backgroundImage =  "url('../../assets/foggy-pine-forest-background-vector.jpg')";
    document.body.style.backgroundPosition = "center";
    document.body.style.backgroundRepeat = "no repeat";
    document.body.style.backgroundAttachment = "fixed";
    document.body.style.backgroundSize = "cover"; 
  }

  ngOnInit(): void {
  }

  ngOnDestroy(){
    document.body.style.backgroundImage = "none";
  }
}
