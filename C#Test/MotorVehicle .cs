using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Test
{/*4.	Create an abstract class MotorVehicle with the following details:
  * Data Members: (a) modelName (b)modelNumber (c) modelPrice 
  * Methods: (a) display() to show all the details
  * Create a subclass of this class Car that inherits the class MotorVehicle 
  * and add the following details: Data Members: (b) discountRate 
  * Methods: (a) display() method to display the Car name, model number, price and the discount rate.
  * (b) discount() method to compute the discount*/
     abstract class MotorVehicle
    {
        public string ModelName;
        public string ModelNumber;
        public double ModelPrice;

        public MotorVehicle(string ModelName,string ModelNumber,double ModelPrice) {
            this.ModelName = ModelName;
            this.ModelNumber = ModelNumber;
            this.ModelPrice = ModelPrice;
        }

        public abstract void Display();
    }

     class Car1 : MotorVehicle
    {
        public double DiscountRate;

        public Car1(string ModelName, string ModelNumber, double ModelPrice,double DiscountRate):base(ModelName, ModelNumber,ModelPrice) { 
            this.DiscountRate = DiscountRate;
        }

        public override void Display() {
            Console.WriteLine("Car detatils:");
            Console.WriteLine("Model Name : "+ModelName);
            Console.WriteLine("Model Number : "+ModelNumber);
            Console.WriteLine("Model Price : "+ ModelPrice);
            Console.WriteLine("Discount Rate: "+DiscountRate+"%");
        }
    }

}
