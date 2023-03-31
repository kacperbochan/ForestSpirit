import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {

  constructor() { 
  }
  page: number = 0;

  public goToPage(num: number): void {
    if (num == 0 || num == 1) {
      this.page = num;
    }
  }

  ngOnInit(): void {
    this.page=0;
  }




}
