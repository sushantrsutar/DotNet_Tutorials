using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //1. Write a C# program to check whether a year is leap year or not
            //    Console.WriteLine("Enter Year : ");
            //    int year=Convert.ToInt32(Console.ReadLine());
            //    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //    {
            //        Console.WriteLine($"{year} is leap year");
            //    }
            //    else {
            //        Console.WriteLine($"{year} is Not leap year");
            //    }
//-------------------------------------------------------------------------------------------------------
            //2.Write a C# program to check whether a number is divisible by 5 and 11 or not
            //Console.WriteLine("Entar The number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //if (num % 5 == 0 && num % 11 == 0)
            //{
            //    Console.WriteLine($"{num} divisible by 5 and 11");
            //}
            //else {
            //    Console.WriteLine($"{num} Not divisible by 5 and 11");
            //}
//---------------------------------------------------------------------------------------------------------
            ////3. Write a C# program to find maximum between three numbers
            //    Console.WriteLine("Enter Three Numbers : ");
            //    int a=Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int c = Convert.ToInt32(Console.ReadLine());
            //    int max;

            //if (a > b)
            //{
            //    if (a > c)
            //    {
            //        max = a;
            //    }
            //    else
            //    {
            //        max = c;
            //    }
            //}
            //else {
            //    if (b > c)
            //    {
            //        max = b;
            //    }
            //    else {
            //        max = c;
            //    }
            //}
            //Console.WriteLine($"max num is {max}");
//--------------------------------------------------------------------------------------------------------
            ////4. Write a C# program to input any alphabet and check whether it is vowel or consonant
            //Console.WriteLine("Enter a character");
            //char ch=Convert.ToChar(Console.ReadLine());
            //char ch1 = char.ToLower(ch);

            //if (ch1 == 'a' || ch1 == 'e' || ch1 == 'i' || ch1 == 'o' || ch1 == 'u')
            //{
            //    Console.WriteLine($"{ch} is vovel");
            //}
            //else {
            //    Console.WriteLine($"{ch} is Not vovel");
            //}
//----------------------------------------------------------------------------------------------------------

            ////5. Write a C# program to create Simple Calculator
            //Console.WriteLine("Enter two numbers : ");
            //int n1=Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter operation (+ - / *): ");
            //char op=Convert.ToChar(Console.ReadLine());

            //if (op == '+')
            //{
            //    Console.WriteLine("addition = " + (n1 + n2));
            //}
            //else if (op == '-')
            //{
            //    Console.WriteLine("substraction = " + (n1 - n2));
            //}
            //else if (op == '*')
            //{
            //    Console.WriteLine("multification = " + (n1 * n2));
            //}
            //else if (op == '/')
            //{
            //    Console.WriteLine("division = " + (n1 / n2));
            //}
            //else {
            //    Console.WriteLine("wrong operation");
            //}
//----------------------------------------------------------------------------------------------------------
            ////6. Write a C# program to check whether a number is negative, positive or zero
            //Console.WriteLine("Enter a Number");
            //int n=Convert.ToInt32(Console.ReadLine());
            //if (n > 0)
            //{
            //    Console.WriteLine($"{n} is positive number");
            //}
            //else if (n == 0)
            //{
            //    Console.WriteLine($"{n} is zero");
            //}
            //else {
            //    Console.WriteLine($"{n} is negetive number");
            //}
//------------------------------------------------------------------------------------------------------
            /*7.Write a C# program to input any character and check whether it is alphabet,
            digit or special character*/
//-----------------------------------------------------------------------------------------------------------
            ////8.Write a C# program to check whether a number is even or odd
            //Console.WriteLine("Enter a Number : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine($"{n} is even number");
            //}
            //else {
            //    Console.WriteLine($"{n} is odd number");
            //}

//------------------------------------------------------------------------------------------------------------
            //9.Write a C# program print total number of days in a month

            ///*10.Write a C# program to input basic salary of an employee and calculate its
            //Gross salary according to following:
            //Basic Salary <= 10000: HRA = 20 %,DA = 80 % 
            //Basic Salary <= 20000: HRA = 25 %,DA = 90 % 
            //Basic Salary > 20000: HRA = 30 %, DA = 95 % */

            //Console.WriteLine("Enter basic salary:");
            //double basic = Convert.ToDouble(Console.ReadLine());
            //double hra = 0, da = 0;
            //if (basic <= 10000) 
            //{ 
            //    hra = 0.2 * basic; 
            //    da = 0.8 * basic; 
            //}
            //else if (basic <= 20000)
            //{
            //    hra = 0.25 * basic;
            //    da = 0.9 * basic; }
            //else {
            //    hra = 0.3 * basic;
            //    da = 0.95 * basic; 
            //}
            //double gross = basic + hra + da;
            //Console.WriteLine($"Gross Salary: {gross}");
//----------------------------------------------------------------------------------------------------------



            /*11.Write a C# program to input electricity consumption unit and calculate totalelectricity billaccording to the given
            condition: For first 50 units Rs. 0.50 / unit For next 100 units Rs. 0.75 / unit For next 100 units Rs.
            1.20 / unit For unit above 250 Rs. 1.50 / unit An additional surcharge of 20 % is added to the bill*/
            //Console.Write("Enter electricity consumption units: ");
            //double units = Convert.ToDouble(Console.ReadLine());
            //double bill = 0;

            //if (units <= 50)
            //{
            //    bill = units * 0.50;
            //}
            //else if (units <= 150)
            //{
            //    bill = (50 * 0.50) + ((units - 50) * 0.75);
            //}
            //else if (units <= 250)
            //{
            //    bill = (50 * 0.50) + (100 * 0.75) + ((units - 150) * 1.20);
            //}
            //else
            //{
            //    bill = (50 * 0.50) + (100 * 0.75) + (100 * 1.20) + ((units - 250) * 1.50);
            //}

            //// Add 20% surcharge
            //double surcharge = bill * 0.20;
            //double totalBill = bill + surcharge;

            //Console.WriteLine($"Electricity Bill (before surcharge): Rs. {bill}");
            //Console.WriteLine($"Surcharge (20%): Rs. {surcharge}");
            //Console.WriteLine($"Total Electricity Bill: Rs. {totalBill}");
//-------------------------------------------------------------------------------------------------------
            /*12.Write a program that displays the day of the week corresponding to the number entered.
            i.e., 1 - "Monday", 2 - "Tuesday" and so on.*/

            //Console.Write("Enter a number (1-7) to get the day of the week: ");
            //int dayNumber = Convert.ToInt32(Console.ReadLine());

            //string day;

            //switch (dayNumber)
            //{
            //    case 1:
            //        day = "Monday";
            //        break;
            //    case 2:
            //        day = "Tuesday";
            //        break;
            //    case 3:
            //        day = "Wednesday";
            //        break;
            //    case 4:
            //        day = "Thursday";
            //        break;
            //    case 5:
            //        day = "Friday";
            //        break;
            //    case 6:
            //        day = "Saturday";
            //        break;
            //    case 7:
            //        day = "Sunday";
            //        break;
            //    default:
            //        day = "Invalid input. Please enter a number between 1 and 7.";
            //        break;
            //}

            //Console.WriteLine($"Day of the week: {day}");
//-----------------------------------------------------------------------------------------------------------
            //13.WAP to swap 2 values of two variables w / o third variable

            //Console.Write("Enter the first value (a): ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second value (b): ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"\nBefore swapping: a = {a}, b = {b}");

            //a = a + b; 
            //b = a - b; 
            //a = a - b; 

            //Console.WriteLine($"After swapping: a = {a}, b = {b}");
//-------------------------------------------------------------------------------------------------------------
            /*14.WAP in C# using switch case for following: Area of a circle Area of a square
             Area of a right angled triangle Area of a rectangle
            Circumference of a circle Perimeter of a square Accept inputs like radius, side, etc
            through keyboard.*/

            //Console.WriteLine("Choose an option:");
            //Console.WriteLine("1. Area of a Circle");
            //Console.WriteLine("2. Area of a Square");
            //Console.WriteLine("3. Area of a Right-Angled Triangle");
            //Console.WriteLine("4. Area of a Rectangle");
            //Console.WriteLine("5. Circumference of a Circle");
            //Console.WriteLine("6. Perimeter of a Square");
            //Console.Write("Enter your choice (1-6): ");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.Write("Enter the radius of the circle: ");
            //        double radius = Convert.ToDouble(Console.ReadLine());
            //        double circleArea = Math.PI * radius * radius;
            //        Console.WriteLine($"Area of the circle: {circleArea:F2}");
            //        break;

            //    case 2:
            //        Console.Write("Enter the side of the square: ");
            //        double side = Convert.ToDouble(Console.ReadLine());
            //        double squareArea = side * side;
            //        Console.WriteLine($"Area of the square: {squareArea:F2}");
            //        break;

            //    case 3:
            //        Console.Write("Enter the base of the triangle: ");
            //        double baseLength = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("Enter the height of the triangle: ");
            //        double height = Convert.ToDouble(Console.ReadLine());
            //        double triangleArea = 0.5 * baseLength * height;
            //        Console.WriteLine($"Area of the triangle: {triangleArea:F2}");
            //        break;

            //    case 4:
            //        Console.Write("Enter the length of the rectangle: ");
            //        double length = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("Enter the breadth of the rectangle: ");
            //        double breadth = Convert.ToDouble(Console.ReadLine());
            //        double rectangleArea = length * breadth;
            //        Console.WriteLine($"Area of the rectangle: {rectangleArea:F2}");
            //        break;

            //    case 5:
            //        Console.Write("Enter the radius of the circle: ");
            //        double radiusCircumference = Convert.ToDouble(Console.ReadLine());
            //        double circumference = 2 * Math.PI * radiusCircumference;
            //        Console.WriteLine($"Circumference of the circle: {circumference:F2}");
            //        break;

            //    case 6:
            //        Console.Write("Enter the side of the square: ");
            //        double squareSide = Convert.ToDouble(Console.ReadLine());
            //        double perimeter = 4 * squareSide;
            //        Console.WriteLine($"Perimeter of the square: {perimeter:F2}");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
            //        break;
            //}

//----------------------------------------------------------------------------------------------------------
            /*15.WAP to print the engineering subjects for a given branch and year.
             * Variable branch specifies the branch - 'C' for CSE, 'E' for ECE, 'M' for Mechanical and 
             * the year specifies the year 1, 2, 3 or 4. We have used nested switch to print the subjects.*/

            Console.Write("Enter the branch ('C' for CSE, 'E' for ECE, 'M' for Mechanical): ");
            char branch = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Enter the year (1, 2, 3, 4): ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSubjects for the selected branch and year:");

            switch (branch)
            {
                case 'C': 
                    switch (year)
                    {
                        case 1:
                            Console.WriteLine("Subjects: Engineering Mathematics, Physics, Chemistry, Programming Basics");
                            break;
                        case 2:
                            Console.WriteLine("Subjects: Data Structures, Object-Oriented Programming, Computer Architecture");
                            break;
                        case 3:
                            Console.WriteLine("Subjects: Operating Systems, Database Management Systems, Networking");
                            break;
                        case 4:
                            Console.WriteLine("Subjects: Machine Learning, Cloud Computing, Cybersecurity");
                            break;
                        default:
                            Console.WriteLine("Invalid year. Please enter a year between 1 and 4.");
                            break;
                    }
                    break;

                case 'E': 
                    switch (year)
                    {
                        case 1:
                            Console.WriteLine("Subjects: Engineering Mathematics, Physics, Chemistry, Circuit Basics");
                            break;
                        case 2:
                            Console.WriteLine("Subjects: Analog Electronics, Digital Electronics, Signal Processing");
                            break;
                        case 3:
                            Console.WriteLine("Subjects: Microprocessors, Communication Systems, Embedded Systems");
                            break;
                        case 4:
                            Console.WriteLine("Subjects: VLSI Design, Wireless Communication, Robotics");
                            break;
                        default:
                            Console.WriteLine("Invalid year. Please enter a year between 1 and 4.");
                            break;
                    }
                    break;

                case 'M': 
                    switch (year)
                    {
                        case 1:
                            Console.WriteLine("Subjects: Engineering Mathematics, Physics, Chemistry, Mechanics");
                            break;
                        case 2:
                            Console.WriteLine("Subjects: Thermodynamics, Fluid Mechanics, Material Science");
                            break;
                        case 3:
                            Console.WriteLine("Subjects: Machine Design, Heat Transfer, Dynamics of Machines");
                            break;
                        case 4:
                            Console.WriteLine("Subjects: Industrial Engineering, Automotive Engineering, Mechatronics");
                            break;
                        default:
                            Console.WriteLine("Invalid year. Please enter a year between 1 and 4.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid branch. Please enter 'C' for CSE, 'E' for ECE, or 'M' for Mechanical.");
                    break;
            }
//----------------------------------------------------------------------------------------------------------









        }
    }
}
