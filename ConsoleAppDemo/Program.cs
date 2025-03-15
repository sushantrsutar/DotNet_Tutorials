using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{

    class Person {
        public String name
        {
            //set { 
            //    name = value;
            //}
            //get {
            //    return name;
            //}
            set; get;
        }
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person()
        {
            Console.WriteLine("default constructor.....");
        }

        public void walk() {
            Console.WriteLine($"{name} is walking");
        }
    }
    internal class Program
    {
        static void sum(int a, int b) {
            Console.WriteLine(a+b);
        }

        static void sum(int a, int b, int c) {
            Console.WriteLine(a+b+c);
        }

        static void sum(params int[] num) {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Roll no");
            //int rollno=Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //string name=Console.ReadLine();
            //Console.WriteLine("Enter Percentage");
            //double per =Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine("Enter branch");
            //string branch=Console.ReadLine();

            //  using + sign - concate
            //Console.WriteLine("print using + sign - concate");
            //Console.WriteLine("Roll No : "+rollno+" , Name : "+name+" , Percentage : "+per+" , Branch : "+branch);

            //// using string interpolation $ sign
            //Console.WriteLine("print using string interpolation $ sign");
            //Console.WriteLine($"Roll No : {rollno} , Name : {name} , Percentage : {per} , Branch : {branch}");

            ////  using placeholder
            //Console.WriteLine("print using placeholder");
            //Console.WriteLine("Roll No : {0} , Name : {1} , Percentage : {2} , Branch : {3}", rollno, name, per, branch);



            //String name = "Sushant Sutar";
            //Console.WriteLine("Name : "+name);
            //String email = "sushantrsutar@gmail.com";
            //Console.WriteLine("Email : "+email);
            //String contact_no = "7875823963";
            //Console.WriteLine("Conatact : "+contact_no);
            //String address = "At-Tirwade ,Taluka-Bhudargad ,Dist-Kolhapur ";
            //Console.WriteLine("Address : "+address);
            //int percentage = 99;
            //Console.WriteLine("Percentage : "+percentage);

            ////StringBuilder
            //StringBuilder sb = new StringBuilder("Sushant");
            //sb.Append(" Sutar ss");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.Length);


            //math class
            //Console.WriteLine(Math.PI);

            //null


            ////object
            //Object student = "this sdasjfn";
            //String str = (string)student;
            //Console.WriteLine(student);
            //Console.WriteLine(str);

            ////do while loop
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //} while (i <= 5);

            ////while loop
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //void show() {
            //    Console.WriteLine("hello");
            //}

            //show();

            ////for loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////continue
            //for (int i = 0; i <= 10; i++) {
            //    if (i % 2 == 0) {
            //        continue;

            //    }
            //    Console.WriteLine(i);
            //}


            //arrays
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            ////range
            //foreach (int i in Enumerable.Range(1, 10))
            //{
            //    Console.WriteLine(i);                
            //}

            //// two d arr

            //int[,] arr = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9},{1,2,3} };
            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr.GetLength(1); j++) {
            //        Console.Write(arr[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}


            //two d array
            //int[,] arr = new int[6, 6];

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        arr[i, j] = i*j;    
            //    }

            //}


            //for (int i = 0; i < 6; i++) {
            //    for (int j = 0; j < 6; j++) {
            //        Console.Write(arr[i,j]+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //method overloading
            //sum(2, 3);
            //sum(2, 3, 4);
            //sum(1, 2, 3, 4, 5);


            Person person = new Person("amol",11);
            Person p1 = new Person();
           
            //person.name = "sushant";
            //person.age = 27;

           Console.WriteLine(person.name+" "+person.age );
            person.walk();












        }
    }
}
