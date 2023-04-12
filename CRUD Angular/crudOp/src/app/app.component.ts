import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private router: Router) { }
  ngOnInit(): void {

  }
  getHome() {
    this.router.navigate(['Home']);
  }
  openForm() {
    this.router.navigate(['addUserLink'])

  }
  title = 'crudOp';
}
