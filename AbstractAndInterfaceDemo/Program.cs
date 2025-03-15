using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceDemo
{
    partial class Calculator
    {
        public void findQube(int a)
        {
            Console.WriteLine("Qube = " + (a * a * a));
        }
    }
    ////static class
    //static class Print {

    //    static int data = 30;
    //    public static void show() {
    //        Console.WriteLine(data);
    //    }
    //}

    //class Address {
    //    public int pincode;
    //    public string city;

    //    public Address(int pincode,string city) {
    //        this.pincode = pincode;
    //        this.city = city;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Pincode : {pincode}, City : {city}";
    //    }
    //}

    //class Person {
    //    public int id;
    //    public string name;
    //    Address address;

    //    public Person(int id,string name,Address address) { 
    //        this.id = id;
    //        this.name = name;
    //        this.address = address;
    //    }

    //    public override string ToString() {
    //        return $"Id : {id} , Name : {name} , Address : {address}";
    //    }
    //}
    internal class Program 
    { 
    //{ abstract class Shape
    //    {
    //        public abstract void calArea();
    //    }

    //    class Req : Shape {
    //        public override void calArea()
    //        {
    //            Console.WriteLine("calcute area ");
    //        }
    //    }

    //    interface Moveable {
    //        void move();
    //    }

    //    class Car : Moveable {
    //        public void move() {
    //            Console.WriteLine("Car moving");
    //        }
    //    }
    //    class Chair : Moveable {
    //        public void move() {
    //            Console.WriteLine("chair moving");
    //        }
    //    }

    //    interface DebitCard {
    //        void Pay(int amt);
    //    }
    //    interface Gpay {
    //        void Pay(int amt);
    //    }
    //    class Transaction : Gpay, DebitCard {
    //        void Gpay.Pay(int amt) {
    //            Console.WriteLine($"{amt} Rs Paid by Gpay");
    //        }

    //        void DebitCard.Pay(int amt) {
    //            Console.WriteLine($"{amt} Rs Paid by Debitcard");
    //        }
    //    }

    //    class Mobile {

    //    }

    //    class Apple : Mobile {

    //    }
    //    //name argument
    //    class Address {
    //        string city;
    //        int pincode;

    //        public Address(string city, int pincode)
    //        {
    //            this.city = city;
    //            this.pincode = pincode;
    //        }

    //        public override string ToString() {
    //            return $"city : {city} , pincode : {pincode}";
    //        }
    //    }

        //public readonly int i;//should be assign or not assign
        //public const int j; //should be assign

         
        static void Main(string[] args)
        {
            //const int j = 123;

            //Req req = new Req();
            //req.calArea();

            //Shape shape = new Req();
            //shape.calArea();

            //Car car = new Car();
            //car.move();

            //Chair chair = new Chair();  
            //chair.move();

            //Moveable moveable;
            //moveable = new Car();
            //moveable=new Chair();


            //Gpay gpay = new Transaction();
            //DebitCard debitCard = new Transaction();

            //gpay.Pay(100);
            //debitCard.Pay(12300);

            //name argumnets
            //Address address = new Address("Kolhapur",416210);
            //Console.WriteLine(address);
            //Address add = new Address(pincode: 123456, city: "Pune");
            //Console.WriteLine(add);

            //partial class
            Calculator calculator = new Calculator();
            //calculator.findQube(5);
            //calculator.add1(2, 3);
            //calculator.findSqure1(5);

            //static class no need to create object
            //Print.show();

            //containtment
            //Person person = new Person(1,"Asha",new Address(112233,"pune"));
            //Console.WriteLine(person);

            //Employee employee = new Employee(1, "Disha", 25000, new Department(121, "Hr"));
            //Console.WriteLine(employee);

            //Department department = new Department(110, "Devops");
            //Employee employee1 = new Employee(2, "Amit",20000, department);
            //Console.WriteLine(employee1);

            //Department dept = new Department(121,"IT");
            //Employee employee2 = new Employee(3, "Jiya", 12345, dept);
            //Console.WriteLine(employee2);

            //Console.WriteLine();

            //Student student1 = new Student(1, "Ram", 99, new Course(101, "ETC"));
            //Student student2 = new Student(2, "Ram", 49, new Course(102, "MECh"));
            //Student student3 = new Student(3, "Ram", 69, new Course(103, "CS"));
            //Student student4 = new Student(4, "Ram", 99, new Course(101, "ETC"));
            //Student student5 = new Student(5, "Ram", 49, new Course(102, "MECh"));
            //Student student6 = new Student(6, "Ram", 69, new Course(103, "CS"));



            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(student3);
            //Console.WriteLine(student4);
            //Console.WriteLine(student5);
            //Console.WriteLine(student6);






        }
    }
}
