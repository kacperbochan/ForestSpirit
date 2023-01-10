import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  constructor() { 
    document.body.style.backgroundImage =  "url('../../assets/foggy-pine-forest-background-vector.jpg')";
    document.body.style.backgroundPosition = "center";
    document.body.style.backgroundRepeat = "no repeat";
    document.body.style.backgroundAttachment = "fixed";
    document.body.style.backgroundSize = "cover"; 
  }

  ngOnInit(): void {
  }

}
