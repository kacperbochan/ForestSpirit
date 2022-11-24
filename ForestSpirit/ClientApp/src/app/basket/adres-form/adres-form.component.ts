import { Component, OnInit } from '@angular/core';
import { Country, ListOfCountries } from 'src/assets/FormData/Country';
import { PhoneDir,ListOfDirectories } from 'src/assets/FormData/PhoneDir';

@Component({
  selector: 'app-adres-form',
  templateUrl: './adres-form.component.html',
  styleUrls: ['./adres-form.component.css']
})
export class AdresFormComponent implements OnInit {

  countries: Country[] = ListOfCountries;
  phones: PhoneDir[] = ListOfDirectories;

  constructor() {   }

  ngOnInit(): void {
  }

}
