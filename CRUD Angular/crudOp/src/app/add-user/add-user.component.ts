import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ApiService } from '../shared/api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {
  constructor(private builder: FormBuilder, private api: ApiService, private router: Router) {

  }
  ngOnInit(): void {

  }
  companyForm = this.builder.group({
    id: this.builder.control({ value: '', disabled: true }),
    name: this.builder.control('', Validators.required),
    technology: this.builder.control('', Validators.required),
    experience: this.builder.control('', Validators.required),
    address: this.builder.control('', Validators.required),


  });

  saveCompany() {
    if (this.companyForm.valid) {
      this.api.createCompany(this.companyForm.value).subscribe(response => {
        if (confirm("Submitted Successfully!.....") == true) {
          this.getHome();

        }
      });
      this.companyForm.reset();
    }
    else {
      alert("Invalid Details......")
    }
  }


  getHome() {
    this.router.navigate(['Home']);
  }
  openForm() {
    this.router.navigate(['/addUserLink']);

    // window.open('/addUserLink', '_blank');

  }


}
