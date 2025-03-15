import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css',
  providers:[StudentService]
})
export class StudentComponent implements OnInit{
 
     studentForm: FormGroup;
      title: string = 'Add Student';
      stuList: any;
      showList: boolean = true;
      showUpdateBtn: boolean = false;
      message: string = '';
     

      constructor(private fb: FormBuilder, private stuService: StudentService) {
          this.studentForm = this.fb.group({
            stuid: [],
            stuname: ['', [Validators.required, Validators.minLength(3)]],
            stuage: [, [Validators.required, Validators.min(6), Validators.max(65)]],
            stupercentage: [, [Validators.required, Validators.min(1),Validators.max(100)]]
          });
        }

        get f() {
          return this.studentForm.controls;
        }
      
        ngOnInit(): void {
          this.getAllStudents();
        }

        onSubmit() {
          if (this.studentForm.valid) {
            if (!this.showUpdateBtn) {
              let stu = {
                stuname: this.studentForm.value.stuname,
                stuage: this.studentForm.value.stuage,
                stupercentage: this.studentForm.value.stupercentage
              };
              this.stuService.postAddStudent(stu).subscribe(() => {
                this.showList = true;
                this.getAllStudents();
              }, (error: string) => {
                this.message = error;
                console.log(error);
              });
            } else {
              let stu = {
                stuid: this.studentForm.value.stuid,
                stuname: this.studentForm.value.stuname,
                stuage: this.studentForm.value.stuage,
                stupercentage: this.studentForm.value.stupercentage
              };
              this.stuService.putUpdateStudent(stu).subscribe(() => {
                this.showList = true;
                this.getAllStudents();
              }, (error: string) => {
                this.message = error;
                console.log(error);
              });
            }
          }
        }

        getAllStudents() {
          this.stuService.getAllStudents().subscribe((res: any) => {
            this.stuList = res;
          }, (error: any) => {
            console.log(error);
          });
        }
      
        toggleForm() {
          this.showList = !this.showList;
          this.showUpdateBtn = false;
          this.studentForm.reset();
        }
      
        editForm(stu: any) {
          this.title = "Update Student";
          this.showUpdateBtn = true;
          this.showList = false;
          this.studentForm.setValue({
            stuid: stu.stuId,
            stuname: stu.stuName,
            stuage: stu.stuAge,
            stupercentage: stu.stuPercentage
          });
        }
      
        deleteStudent(stuId: number) {
          if (confirm('Are you sure you want to delete this Student ?')) {
            this.stuService.deleteStudent(stuId).subscribe(() => {
              this.getAllStudents();
            }, (error: string) => {
              this.message = error;
              console.log(error);
            });
          }
        }
}
