import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employee',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css',
  providers: [EmployeeService]
})
export class EmployeeComponent implements OnInit {
  employeeForm: FormGroup;
  title: string = 'Add Employee';
  empList: any;
  showList: boolean = true;
  showUpdateBtn: boolean = false;
  message: string = '';

  constructor(private fb: FormBuilder, private empService: EmployeeService) {
    this.employeeForm = this.fb.group({
      empid: [],
      empname: ['', [Validators.required, Validators.minLength(3)]],
      empage: [, [Validators.required, Validators.min(18), Validators.max(65)]],
      empsalary: [, [Validators.required, Validators.min(1)]]
    });
  }

  get f() {
    return this.employeeForm.controls;
  }

  ngOnInit(): void {
    this.getAllEmployees();
  }

  onSubmit() {
    if (this.employeeForm.valid) {
      if (!this.showUpdateBtn) {
        let emp = {
          empname: this.employeeForm.value.empname,
          empage: this.employeeForm.value.empage,
          empsalary: this.employeeForm.value.empsalary
        };
        this.empService.postAddEmployee(emp).subscribe(() => {
          this.showList = true;
          this.getAllEmployees();
        }, error => {
          this.message = error;
          console.log(error);
        });
      } else {
        let emp = {
          empid: this.employeeForm.value.empid,
          empname: this.employeeForm.value.empname,
          empage: this.employeeForm.value.empage,
          empsalary: this.employeeForm.value.empsalary
        };
        this.empService.putUpdateEmployee(emp).subscribe(() => {
          this.showList = true;
          this.getAllEmployees();
        }, error => {
          this.message = error;
          console.log(error);
        });
      }
    }
  }

  getAllEmployees() {
    this.empService.getAllEmployees().subscribe(res => {
      this.empList = res;
    }, error => {
      console.log(error);
    });
  }

  toggleForm() {
    this.showList = !this.showList;
    this.showUpdateBtn = false;
    this.employeeForm.reset();
  }

  editForm(emp: any) {
    this.title = "Update Employee";
    this.showUpdateBtn = true;
    this.showList = false;
    this.employeeForm.setValue({
      empid: emp.empId,
      empname: emp.empName,
      empage: emp.empAge,
      empsalary: emp.empSalary
    });
  }

  deleteEmployee(empId: number) {
    if (confirm('Are you sure you want to delete this employee?')) {
      this.empService.deleteEmployee(empId).subscribe(() => {
        this.getAllEmployees();
      }, error => {
        this.message = error;
        console.log(error);
      });
    }
  }
}
