import { Component, Input, OnInit } from '@angular/core';
import { orderElem } from 'src/Models/order';
import { Produkt } from 'src/Models/produkt';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.css']
})
export class RegisterFormComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {}

  public tryRegister(): void {

  }
}
