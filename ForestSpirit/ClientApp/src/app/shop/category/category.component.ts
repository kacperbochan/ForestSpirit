import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent {

  @Input() CategoryName: String
  @Input() ClickCallback: () => void
  @Input() IsSelected: boolean = false

}
