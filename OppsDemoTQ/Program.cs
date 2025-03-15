using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsDemoTQ
{   /*Create Employee class --> with id,name,department,salary accept the data & display emp details
Create Book class --> bookid, name,price, author name --> accept & display*/
    internal class Program
    {
        class Book {
            public int bookId;
            public string bookName;
            public double bookPrice;
            

            public Book(int bookId, string bookName, double bookPrice)
            {
                this.bookId = bookId;
                this.bookName = bookName;
                this.bookPrice = bookPrice;
            }

            public void showBook() {
                Console.WriteLine($"Book Id : {this.bookId}\nBook Name : {this.bookName}\nBook Price : {this.bookPrice}");
            }
        }

        //class Employee {
        //    public int eId;
        //    public string eName;
        //    public string eDepartment;
        //    public double eSalary;
        //    public Employee(int eId,string eName,string eDepartment,double eSalary) {
        //        this.eId = eId;
        //        this.eName = eName;
        //        this.eDepartment = eDepartment;
        //        this.eSalary = eSalary;
        //    }

        //    public void dispaly() {
        //        Console.WriteLine($"Id : {this.eId}\nName : {this.eName}\nDepartment : {this.eDepartment}\nSalary : {this.eSalary}");
        //    }
        //}
        class Student {

            public int id = 101;
            public string name = "Amol";
            public double marks = 99;
            public static string clgName = "SETI";
            public void walk() {
                Console.WriteLine("Student is walking");
            }

            //static constructor invoke only once
            static Student() {
                clgName = "ICRE";//we can change here staric data value for all objects
                Console.WriteLine("static constructor");
            }
            public void show() {
                Console.WriteLine($"Student Id : {this.id}\nStudent Name : {this.name}\nStudent Marks : {this.marks}\nCollage Name : {Student.clgName}");
            }

            //public void acceptData(int id, string name, double marks) { 
            //    this.id = id;
            //    this.name = name;
            //    this.marks = marks;
            //}

            public static void showStatic () {
                Console.WriteLine($"Collage name : {Student.clgName}");
                //Console.WriteLine("name"+Student.name);have only static filds
            }

            public Student(int id, string name, double marks)
            {
                this.id = id;
                this.name = name;
                this.marks = marks;
            }   
        }
        static void Main(string[] args)
        {

            //    Student student = new Student();
            //    student.walk();

            //    student.show();

            ////Student student2 = new Student();
            //student2.acceptData(102, "Ram", 123);
            //student2.show();


            //Student s1 = new Student(103, "Sneha", 123);
            //s1.show();

            //Student s2 = new Student(104, "neha", 100);
            //s2.show();

            //Student.showStatic();

            //Employee emp = new Employee(101, "sham", "ECE", 25000);
            //emp.dispaly();

            //Book book = new Book(101,"Kalki",1000);
            //book.showBook();

            //product class with properties
            //case 1

            //Product p1 = new Product();
            //Console.WriteLine("Enter Id : ");
            //int id=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name : ");
            //string name=Console.ReadLine();
            //Console.WriteLine("Enter price :");
            //double price=Convert.ToDouble(Console.ReadLine());
            //p1.ProductId = id;
            //p1.ProductName = name;
            //p1.ProductPrice = price;
            //Console.WriteLine(p1.show());

            //case 2
            //Product p2 = new Product() { ProductId = 1, ProductName = "Mobile", ProductPrice = 30000 };
            //Console.WriteLine(p2.show());

            //Employee class get set
            Employee emp = new Employee() { empid = 1, empname="amol", empsalary = 1230 };
            Console.WriteLine(emp.show());

        }
    }
}
