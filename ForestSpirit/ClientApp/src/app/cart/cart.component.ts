import { Component, OnInit } from '@angular/core';
import { orderElem } from 'src/types/order';
import { Produkt } from 'src/types/produkt';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  public page:number = 0;
  public produkty:orderElem[] = [];
  constructor() {
    document.body.style.backgroundImage = "url('../../assets/foggy-pine-forest-background-vector.jpg')";
    document.body.style.backgroundPosition = "center";
    document.body.style.backgroundRepeat = "no repeat";
    document.body.style.backgroundAttachment = "fixed";
    document.body.style.backgroundSize = "cover";
  }

  ngOnInit(): void {
    let element1 = new orderElem(new Produkt("Bimber 1", "dlugi opis produktu", 123, 3.02, "assets/zdjecie_brak_pionowe.jpg"),2);
    let element2 = new orderElem(new Produkt("Bimber 2", "dlugi opis produktu", 323, 3.21, "assets/zdjecie_brak_pionowe.jpg"),1);
    let element3 = new orderElem(new Produkt("Bimber 3", "dlugi opis produktu", 232, 4.77, "assets/zdjecie_brak_pionowe.jpg"),3);
    let element4 = new orderElem(new Produkt("Bimber 4", "dlugi opis produktu", 99.00, 4.64, "assets/zdjecie_brak_pionowe.jpg"),1);

    this.produkty = new Array(element1,element2,element3,element4);
  }

  public nextPage():void{
    if(this.page<2)this.page++;
  }

  public previousPage():void{
    if(this.page>0)this.page--;
  }

  public goToPage(num:number):void{
    if(num>=0&&num<=2){
      this.page=num;
    }
  }
}
