import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about-component',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {

  constructor() { 
    document.body.style.backgroundImage = "url('../../assets/foggy-pine-forest-background-vector.jpg)";
    document.body.style.backgroundPosition = "center";
    document.body.style.backgroundRepeat = "no repeat";
    document.body.style.backgroundAttachment = "fixed";
    document.body.style.backgroundSize = "cover"; 
  }

  ngOnInit(): void {
  }

  ngOnExit(){
    document.body.style.backgroundImage = "none";
  }

}
