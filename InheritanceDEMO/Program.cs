using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDEMO
{
    internal class Program
    {

        //abstract class Person {
        //    public string name = "Sam";
        //    public uint age = 27;

        //    //abstract public void talk(); 
        //    public void show() {
        //        Console.WriteLine("person show method");
        //    }
        //}

        //class Doctor : Person {

        //    public Doctor() { }

        //    public Doctor(String name,uint age,string hospitalName) {
        //        this.name = name;
        //        this.age = age;
        //        this.hospitalName = hospitalName;

        //    }
        //    string hospitalName= string.Empty;

        //    public void printData() {
        //        Console.WriteLine($"Name : {name}, Age : {age}, Hospital Name :{hospitalName}");
        //    }
        //    //public override void talk() {
        //    //    Console.WriteLine("Doctor Talking...");
        //    //}

        //}
        //class Engineer : Person{ 
        //    string companyName= string.Empty;
        //    public Engineer() { }

        //    public Engineer(String name ,uint age,String companyName)
        //    {   this.name = name;
        //        this.age = age;
        //        this.companyName = companyName;
        //    }

        //    public void printData() {
        //        Console.WriteLine($"Name : {name}, Age : {age}, Comapany Name : {companyName}");
        //    }

        //    public override string ToString()
        //    {
        //        return $"Name: {this.name} Age: {this.age} Company Name :{this.companyName}";
        //    }

        //    //public override void talk() {
        //    //    Console.WriteLine("Engineer Talking....");
        //    //}
        //}

        //class Student : Person {
        //    public void show() {
        //        base.show();
        //        Console.WriteLine($"Name:{base.name},age:{base.age}");
        //    }
        //}

        //class Vehicle {
        //    //protected Vehicle() {
        //    //    Console.WriteLine("this is vehicle");
        //    //}

        //    protected int speed;
        //    protected double price;
        //    public Vehicle(int speed,double price) {
        //        this.speed = speed; 
        //        this.price = price;
        //    }
        //    protected virtual void drive(int speed) {
        //        Console.WriteLine("drive from parent");
        //    }
        //}

        //class Car:Vehicle {
        //    //public Car:base(){} //implicitly use this code
        //    //public Car() {
        //    //    Console.WriteLine("this is car");
        //    //}
        //    public string modelName;
        //    public Car(int speed, double price,string modelName) : base(speed, price){
        //        this.modelName = modelName;
        //    }

        //    protected override void  drive(int speed) {
        //        Console.WriteLine("drive from child");
        //    }

        //}

        //class Addition {
        //    public void sum(int a, int b) {
        //        Console.WriteLine("Addition :" +(a+b));
        //    }

        //    public void sum(int a, int b,int c)
        //    {
        //        Console.WriteLine("Addition :" + (a + b + c));
        //    }

        //    public void sum(double a, double b)
        //    {
        //        Console.WriteLine("Addition :" + (a + b));
        //    }
        //}

        /*3.A vehicle has four wheels and a color assigned to it.
        A car is a vehicle with a seating capacity of four.
        An SUV is a car which has a 800 horsepower engine. Create a model detailing the same.*/
        class Vehicle
        {
            public int wheels { set; get; }
            public string color { set; get; }

            public Vehicle(int wheels, string color)
            {
                this.wheels = wheels;
                this.color = color;
            }

            public override string ToString()
            {
                return $"vehicle has {wheels} wheels and color is {color}";
            }
        }

        class Car : Vehicle
        {
            public int seatingCapacity { set; get; }
            public Car(int wheels, string color, int seatingCapacity) : base(wheels, color)
            {

                this.seatingCapacity = seatingCapacity;

            }

            public override string ToString()
            {
                return $"Car Details - wheels : {wheels} , color : {color} , seating capacity : {seatingCapacity}";
            }

        }

        class SUV : Car
        {
            public int horsepower { set; get; }

            public SUV(int wheels, string color, int seatingCapacity, int horsepower) : base(wheels, color, seatingCapacity)
            {
                this.horsepower = horsepower;
            }

            public override string ToString()
            {
                return $"SUV Details - wheels : {wheels} , color : {color} , seating capacity : {seatingCapacity} , horse power : {horsepower}";
            }
        }

        /*4. Create a base class Student having id , name , Create subclass SchoolStudent having class, schoolName ,
         * marks. Create a class CollegeStudent having clgName, sem . 
         * Both the class extends Student class, Create object and display them*/

        class Student { 
            public int stuId { set; get; }
            public string stuName { set; get; }

            public Student(int stuId, string stuName)
            {
                this.stuId = stuId;
                this.stuName = stuName;
            }

            public override string ToString()
            {
                return $"Student Id : {stuId} ,Student Name : {stuName}";
            }
        }

        class SchoolStudent:Student { 
            public String schoolName { set; get; }
            public int marks { set; get; }

            public SchoolStudent(int stuId,string stuName,string schoolName, int marks):base(stuId, stuName) 
            {
                this.schoolName = schoolName;
                this.marks = marks;
            }

            public override string ToString()
            {
                return "School Student - "+base.ToString()+$", School Name : {schoolName} , Marks : {marks}";
            }

        }
        class CollegeStudent:Student { 
            public string collegeName { set; get; }
            public int sem { set; get; }

            public CollegeStudent(int stuId,string stuName, string collegeName, int sem):base(stuId, stuName) 
            {
                this.collegeName = collegeName;
                this.sem = sem;
            }

            public override string ToString()
            {
                return "Collage Student - "+base.ToString()+$" Collage Name : {collegeName} , Sem : {sem}";
            }
        }
        static void Main(string[] args)
        {
            //Doctor doctor= new Doctor("Amit",27,"VKC");
            //Engineer engineer= new Engineer("Ram",28,"TCS");
            //Console.WriteLine(engineer);
            //Student student= new Student();

            //doctor.talk();
            //doctor.printData();
            //engineer.talk();
            //engineer.printData(); 

            //student.show();

            //Car car= new Car();

            //Car car = new Car(120,1500000,"Tata");

            //Addition addition= new Addition();
            //addition.sum(1, 4);
            //addition.sum(1, 2, 3);

            Car car = new Car(4,"balck",5);
            Console.WriteLine(car);
            SUV suv = new SUV(4,"red",7,1200);
            Console.WriteLine(suv);

            SchoolStudent schoolStudent = new SchoolStudent(1, "Amit", "SVM", 99);
            Console.WriteLine(schoolStudent);
            CollegeStudent collegeStudent = new CollegeStudent(102, "Neha", "SETI", 8);
            Console.WriteLine(collegeStudent);
        }
    }
}
