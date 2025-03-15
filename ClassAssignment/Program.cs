using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Account
    {
        private int accno;
        private string name;
        private double amount;
        public void Insert(int accountNumber, string accountHolderName, double initialAmount)
        {
            accno = accountNumber;
            name = accountHolderName;
            amount = initialAmount;
            Console.WriteLine("Account created successfully!");
        }
        public void Display()
        {
            Console.WriteLine("Account Number: " + accno);
            Console.WriteLine("Account Holder Name: " + name);
            Console.WriteLine("Account Balance: " + amount);
        }

        public void Deposit(double depositAmount)
        {
            if (depositAmount > 0)
            {
                amount += depositAmount;
                Console.WriteLine($"Successfully deposited {depositAmount}. New Balance: {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }
        public void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount > 0 && withdrawAmount <= amount)
            {
                amount -= withdrawAmount;
                Console.WriteLine($"Successfully withdrawn {withdrawAmount}. Remaining Balance: {amount}");
            }
            else if (withdrawAmount > amount)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + amount);
        }
    }

    class Employee {
        private int id;
        private string ename;
        private double basicsal;
        private double pf;
        private double hra;
        private double da;
        private double netsal;
        private int deptno;

        public Employee()
        {
            id = 0;
            ename = "Unknown";
            basicsal = 0.0;
            deptno = 0;
        }
        public Employee(int empId, string empName, double basicSalary, int departmentNo)
        {
            id = empId;
            ename = empName;
            basicsal = basicSalary;
            deptno = departmentNo;
        }

        public void CalculateSalary()
        {
            pf = 0.10 * basicsal;
            hra = 0.15 * basicsal;
            da = 0.20 * basicsal;
            netsal = basicsal + da + hra - pf;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + ename);
            Console.WriteLine("Department Number: " + deptno);
            Console.WriteLine("Basic Salary: " + basicsal);
            Console.WriteLine("PF (10%): " + pf);
            Console.WriteLine("HRA (15%): " + hra);
            Console.WriteLine("DA (20%): " + da);
            Console.WriteLine("Net Salary: " + netsal);
        }
    }

    class Student
    {
       
        private int rollno;
        private string name;
        private int sub1, sub2, sub3, sub4, sub5;
        private double percentage;
        private int total;
        private char grade;

       
        public Student(int rollno, string name, int sub1, int sub2, int sub3, int sub4, int sub5)
        {
            this.rollno = rollno;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.sub4 = sub4;
            this.sub5 = sub5;
            CalculatePercentage();
            CalculateGrade();
        }

        
        public void CalculatePercentage()
        {
            total = sub1 + sub2 + sub3 + sub4 + sub5;
            percentage = (total / 5.0);
        }
        public void CalculateGrade()
        {
            if (percentage >= 90)
                grade = 'A';
            else if (percentage >= 75)
                grade = 'B';
            else if (percentage >= 50)
                grade = 'C';
            else if (percentage >= 35)
                grade = 'D';
            else
                grade = 'F';
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Roll Number: " + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Subject 1: " + sub1);
            Console.WriteLine("Subject 2: " + sub2);
            Console.WriteLine("Subject 3: " + sub3);
            Console.WriteLine("Subject 4: " + sub4);
            Console.WriteLine("Subject 5: " + sub5);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage: " + percentage + "%");
            Console.WriteLine("Grade: " + grade);
        }

        public void ComparePercentage(Student otherStudent)
        {
            if (this.percentage > otherStudent.percentage)
                Console.WriteLine($"{this.name} has a higher percentage ({this.percentage}%) than {otherStudent.name} ({otherStudent.percentage}%).");
            else if (this.percentage < otherStudent.percentage)
                Console.WriteLine($"{otherStudent.name} has a higher percentage ({otherStudent.percentage}%) than {this.name} ({this.percentage}%).");
            else
                Console.WriteLine($"{this.name} and {otherStudent.name} have the same percentage ({this.percentage}%).");
        }
    }

    class Product
    {
        private int proId;
        private string name;
        private string description;
        private double price;
        private int quantity;
        private double discount;

        public Product(int productId, string productName, string productDescription, double productPrice, int productQuantity, double productDiscount)
        {
            proId = productId;
            name = productName;
            description = productDescription;
            price = productPrice;
            quantity = productQuantity;
            discount = productDiscount;
        }

        public double CalculateTotalPrice()
        {
            return price * quantity;
        }

        public double CalculateDiscountPrice()
        {
            double totalPrice = CalculateTotalPrice();
            double discountAmount = (discount / 100) * totalPrice;
            return totalPrice - discountAmount;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product ID: " + proId);
            Console.WriteLine("Product Name: " + name);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Discount: " + discount + "%");
            Console.WriteLine("Total Price (Before Discount): " + CalculateTotalPrice());
            Console.WriteLine("Total Price (After Discount): " + CalculateDiscountPrice());
        }
    }
    class Product1 {
        private int id;
        private string name;
        private double price;

        private static string company;

        static Product1() {
            company = "LG";
        }

        public Product1(int id, String name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public void show() {
            Console.WriteLine("id : "+id);
            Console.WriteLine("name : "+name);
            Console.WriteLine("price : "+price);
            Console.WriteLine("company Name : " +company);
                
         }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account class
            //Account account = new Account();
            //account.Insert(101, "Amit", 1000.0);
            //account.Display();
            //account.Deposit(500);
            //account.Withdraw(300);
            //account.CheckBalance();
            //account.Withdraw(1500);
            //account.Deposit(-100);


            //Employee class
            //Employee emp1 = new Employee();
            //Console.WriteLine("Employee created using default constructor:");
            //emp1.DisplayEmployee();
            //Console.WriteLine();

            //Employee emp2 = new Employee(101, "Sham", 50000.0, 10);
            //Console.WriteLine("\nEmployee created using parameterized constructor:");
            //emp2.CalculateSalary();
            //emp2.DisplayEmployee();
            //Console.WriteLine();

            //Student class
            //Student student1 = new Student(1, "Neha", 85, 90, 78, 88, 92);
            //Student student2 = new Student(2, "Priya", 80, 85, 82, 78, 90);
            //Console.WriteLine("Student 1 Details:");
            //student1.DisplayStudent();
            //Console.WriteLine();
            //Console.WriteLine("Student 2 Details:");
            //student2.DisplayStudent();
            //Console.WriteLine();
            //Console.WriteLine("Percentage Comparison:");
            //student1.ComparePercentage(student2);


            //product class
            //Product product = new Product(101, "Laptop", "High-performance gaming laptop", 75000, 2, 10);
            //Console.WriteLine("Product Details:");
            //product.DisplayProduct();

            //Product1 p1 = new Product1(1, "TV", 12000);
            //p1.show();

            //Product1 p2 = new Product1(2, "Radio", 1000);
            //p2.show();


            //EmployeeStatic
            //EmployeeStatic emp1 = new EmployeeStatic("Amit", 2000);
            //Console.WriteLine(emp1.show());

            //EmployeeStatic emp2 = new EmployeeStatic("Amit", 2000);
            //Console.WriteLine(emp2.show());

            //EmployeeStatic emp3 = new EmployeeStatic("Amit", 2000);
            //Console.WriteLine(emp3.show());

            //EmployeeStatic emp4 = new EmployeeStatic("Amit", 2000);
            //Console.WriteLine(emp4.show());

            //Console.WriteLine("Total Employees : "+EmployeeStatic.EmployeeCount);



            ////SecretBankAccount
            //SecretBankAccount account = new SecretBankAccount("President of the Nation", "SecurePassword123");

            //// Family members can view account details
            //Console.WriteLine("Family members viewing the account details:");
            //account.ViewAccountDetails();

            //// Trying to add money with incorrect password (family member attempt)
            //Console.WriteLine("\nFamily member trying to add money:");
            //account.AddMoney(5000, "WrongPassword");

            //// President adds money using the correct password
            //Console.WriteLine("\nPresident adding money:");
            //account.AddMoney(10000, "SecurePassword123");

            //// Family members view updated account details
            //Console.WriteLine("\nUpdated account details viewed by family members:");
            //account.ViewAccountDetails();


            //Book
            //    Book[] books = new Book[4];

            //    // Take user input to create 4 books
            //    for (int i = 0; i < 4; i++)
            //    {
            //        Console.WriteLine($"Enter details for Book {i + 1}:");
            //        Console.Write("ID: ");
            //        int id = int.Parse(Console.ReadLine());
            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();
            //        Console.Write("Price: ");
            //        double price = double.Parse(Console.ReadLine());
            //        Console.Write("Category (e.g., Fiction, Non-Fiction, Educational, etc.): ");
            //        string category = Console.ReadLine();

            //        books[i] = new Book(id, name, price, category);
            //    }

            //    // Calculate discount for all books
            //    Console.WriteLine("\nCalculating Discount for all books:");
            //    foreach (var book in books)
            //    {
            //        book.CalDiscount();
            //    }

            //    // Compare the cost of any two books
            //    Console.WriteLine("\nEnter the numbers of two books to compare (1-4):");
            //    int bookIndex1 = int.Parse(Console.ReadLine()) - 1;
            //    int bookIndex2 = int.Parse(Console.ReadLine()) - 1;

            //    if (bookIndex1 >= 0 && bookIndex1 < 4 && bookIndex2 >= 0 && bookIndex2 < 4)
            //    {
            //        Console.WriteLine("\nComparing books:");
            //        Book.CompareDiscCost(books[bookIndex1], books[bookIndex2]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid book numbers entered.");
            //    }


            //car1 
            //Car1 car1 = new Car1("Toyota Corolla", 20000, "Petrol", "MH12AB1234");
            //Car1 car2 = new Car1("Honda Civic", 25000, "Diesel", "MH14CD5678");
            //Car1 car3 = new Car1("Tesla Model 3", 50000, "Electric", "MH15EF9012");

            //// Display car details
            //Console.WriteLine("Car Details:");
            //car1.Show();
            //car2.Show();
            //car3.Show();

            //// Simulate sales
            //Console.WriteLine("\nSimulating sales:");
            //car1.Sales();
            //car2.Sales();
            //car3.Sales();

            //// Get total sales and revenue
            //Console.WriteLine("\nTotal Sales and Revenue:");
            //Console.WriteLine($"Total Cars Sold: {Car1.GetTotalSales()}");
            //Console.WriteLine($"Total Revenue: {Car1.GetTotalRevenue():C}");



        }

    }
    
}
