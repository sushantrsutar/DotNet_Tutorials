using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{   /*5.Write a Car class with following datamember
    model,price,fueltype,registrationnumber,
    static datamember : totalSales,toRevenue
    Write appropriate constructors ,methods - Show ,Sales
    static method :GetTotalSales,GetTotalRevenue 
    Write main method -create Car class object ,invoke sales method .
    call GetTotalRevenue and GetTotalSales method to find total sales and revenue."*/
    internal class Car1
    {
        public string Model { get; private set; }
        public double Price { get; private set; }
        public string FuelType { get; private set; }
        public string RegistrationNumber { get; private set; }

        private static int totalSales = 0; 
        private static double totalRevenue = 0;

        public Car1(string model, double price, string fuelType, string registrationNumber)
        {
            Model = model;
            Price = price;
            FuelType = fuelType;
            RegistrationNumber = registrationNumber;
        }

        public void Show()
        {
            Console.WriteLine($"Model: {Model}, Price: {Price:C}, Fuel Type: {FuelType}, Registration Number: {RegistrationNumber}");
        }

        public void Sales()
        {
            totalSales++;
            totalRevenue += Price;
            Console.WriteLine($"Car \"{Model}\" with registration number {RegistrationNumber} sold for {Price:C}.");
        }

        public static int GetTotalSales()
        {
            return totalSales;
        }

        public static double GetTotalRevenue()
        {
            return totalRevenue;
        }

    }
}
