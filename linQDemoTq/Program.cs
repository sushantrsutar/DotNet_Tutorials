using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQDemoTq
{
    public class Employee { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Dept { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary} , Dept : {Dept}";
        }

    }

    public class Product { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public string Company { get; set; }

        public override String ToString() {
            return $"Id:{Id} , Name:{Name} , Price:{Price} , Company:{Company}";
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>() {
                new Employee{Id=1,Name="Amol",Salary=1200,Dept="EE" },
                new Employee{Id=2,Name="Ram",Salary=1400,Dept="ME" },
                new Employee{Id=3,Name="Sham",Salary=1100,Dept="CE" },
                new Employee{Id=4,Name="Amit",Salary=1500,Dept="EE" },
                new Employee{Id=5,Name="Raj",Salary=1000,Dept="ECE" },
                new Employee{Id=6,Name="Neha",Salary=2200,Dept="EE" },
                new Employee{Id=7,Name="Priya",Salary=3400,Dept="ME" },
                new Employee{Id=8,Name="Teja",Salary=4100,Dept="ECE" },
                new Employee{Id=9,Name="Ravi",Salary=5500,Dept="EE" },
                new Employee{Id=10,Name="Sakshi",Salary=21000,Dept="ECE" }
            };

            //LinQ And lambda 
            //var ser1=from e in list
            //         select e;


            //foreach (Employee emp in ser1) {
            //    Console.WriteLine(emp);
            //}

            //var res2 = from e in list
            //           where e.Salary > 1230
            //           select e;

            //foreach (Employee emp in res2) {
            //    Console.WriteLine(emp);
            //}

            //var res3=from e in list
            //         where e.Salary>23000 && e.Dept.Contains("EE")
            //         select e;
            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //}

            //var res5=from e in list
            //         orderby e.Name
            //         select e;
            //foreach (Employee e in res5) {
            //    Console.WriteLine(e);
            //}

            //var salarydece = from e in list
            //                 orderby e.Salary descending
            //                 select e;
            //foreach (var item in salarydece)
            //{
            //    Console.WriteLine(item);
            //}

            //lambda
            //var res1=list.Where(x=>x.Salary>5000).OrderBy(x=>x.Name).ToList();
            //foreach (Employee emp in res1) {
            //    Console.WriteLine(emp);
            //}

            //var top3 = list.Take(3);
            //foreach (Employee emp in top3) {
            //    Console.WriteLine(emp);
            //}

            //var skip3 = list.Skip(3);
            //foreach (var item in skip3) {
            //    Console.WriteLine(item);
            //}

            List<Product> product = new List<Product>() {
            new Product{Id=1,Name="Tv",Company="Lg",Price=12000 },
            new Product{Id=2,Name="Mobile",Company="MI",Price=22000 },
            new Product{Id=3,Name="Fridge",Company="Lg",Price=10000 },
            new Product{Id=4,Name="Camera",Company="Canon",Price=122000 },
            new Product{Id=5,Name="Laptop",Company="HP",Price=123000 },
            new Product{Id=6,Name="Pc",Company="HP",Price=32000 },
            new Product{Id=7,Name="Tv",Company="Onida",Price=42000 },
            new Product{Id=8,Name="Pc",Company="HP",Price=42000 },
            new Product{Id=9,Name="Laptop",Company="Dell",Price=125000 },
            new Product{Id=10,Name="Watch",Company="Tata",Price=2000 }
            };

            //display all products
            //var alldata = from p in product
            //              select p;
            //foreach (var p in alldata)
            //{
            //    Console.WriteLine(p);
            //}

            //product price less than 23000
            //var price = from p in product
            //            where p.Price<23000
            //            select p;

            //foreach (var item in price) {
            //    Console.WriteLine(item);
            //}

            //sort price desending order
            //var sort = from p in product
            //           orderby p.Price descending
            //           select p;
            //foreach (var item in sort) {
            //    Console.WriteLine(item);
            //}

            //company=Hp
            //var hp=from p in product
            //       where p.Company=="HP"
            //       select p;
            //foreach (var p in hp) {
            //    Console.WriteLine(p);
            //}

            //top 3 product
            //var take3=product.Take(3);
            //foreach (var item in take3) {
            //    Console.WriteLine(item);
            //}



        }
    }
}
