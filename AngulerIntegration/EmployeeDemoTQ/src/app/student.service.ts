import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  baseUrl:string="http://localhost:5183/api/Student/";
  constructor(private http:HttpClient) { }

  postAddStudent(stu:any):Observable<any>{
      return this.http.post<any>(this.baseUrl+"AddStudent",stu)
      .pipe(catchError(this.handleError));
    }
  
    putUpdateStudent(stu:any):Observable<any>{
      return this.http.put<any>(this.baseUrl+"UpdateStudent",stu)
      .pipe(catchError(this.handleError));
    }
  
    getAllStudents():Observable<any>
    {
      return this.http.get<any>(this.baseUrl+"GetAllStudents")
      .pipe(catchError(this.handleError))
    }
  
    deleteStudent(stuId: number): Observable<any> {
      return this.http.delete<any>(`${this.baseUrl}DeleteStudent/${stuId}`)
        .pipe(catchError(this.handleError));
    }


    private handleError(error: HttpErrorResponse) {
        // Handle error appropriately
        let errorMessage = 'An unknown error occurred!';
        if (error.error instanceof ErrorEvent) {
          // Client-side or network error
          errorMessage = `Error: ${error.error.message}`;
        } else {
          // Server-side error
          errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
        }
        return throwError(errorMessage);
      }
}
