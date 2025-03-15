import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseUrl:string="http://localhost:5183/api/Employee/";
  constructor(private http:HttpClient) { }


  // add employee method


  postAddEmployee(emp:any):Observable<any>{
    return this.http.post<any>(this.baseUrl+"AddEmployee",emp)
    .pipe(catchError(this.handleError));
  }

  putUpdateEmployee(emp:any):Observable<any>{
    return this.http.put<any>(this.baseUrl+"UpdateEmployee",emp)
    .pipe(catchError(this.handleError));
  }

  getAllEmployees():Observable<any>
  {
    return this.http.get<any>(this.baseUrl+"GetEmployees").pipe(catchError(this.handleError))
  }

  deleteEmployee(empId: number): Observable<any> {
    return this.http.delete<any>(`${this.baseUrl}DeleteEmployee/${empId}`)
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
