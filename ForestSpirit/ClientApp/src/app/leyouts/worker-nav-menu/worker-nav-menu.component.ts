import { Component } from '@angular/core';

@Component({
  selector: 'app-worker-nav-menu',
  templateUrl: './worker-nav-menu.component.html',
  styleUrls: ['./worker-nav-menu.component.css']
})
export class WorkerNavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

}
