import { Component, Input, OnInit } from '@angular/core';
import { orderElem } from 'src/Models/order';
import { Produkt } from 'src/Models/produkt';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {}

  public tryLogin(): void {

  }
}
