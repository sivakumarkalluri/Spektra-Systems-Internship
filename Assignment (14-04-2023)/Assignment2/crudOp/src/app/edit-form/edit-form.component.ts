import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { ApiService } from '../shared/api.service';
import { companyModel } from '../companymodel';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-form',
  templateUrl: './edit-form.component.html',
  styleUrls: ['./edit-form.component.css']
})
export class EditFormComponent {


  constructor(private companyData: ApiService, private builder: FormBuilder, private router:Router) { }
  editedId = this.companyData.editId;

  companyDetails!: companyModel[];
  ngOnInit(): void {
    this.companyData.getCompanyDetails().subscribe(data => {
      this.companyDetails = data;
    })

  }


  companyForm = this.builder.group({
    id: this.builder.control({ value: this.editedId.id, disabled: true }),
    name: this.builder.control(this.editedId.name, Validators.required),
    technology: this.builder.control(this.editedId.technology, Validators.required),
    experience: this.builder.control( {value: this.editedId.id,disabled:false}, Validators.required),
    address: this.builder.control(this.editedId.address, Validators.required),
  
  });

  editedData!: companyModel[];
  editSaveEmployee() {
    if (this.companyForm.valid) {
      this.companyData.editCompanyData(this.companyForm.value).subscribe((data) => {
        this.editedData = data;
        if (confirm("Edited Successfully!.....") == true) {
          this.getHome();

        }
      })
    }
    this.companyForm.reset();


  }


  getHome() {
    this.router.navigate(['Home']);
  }



}
