using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    internal class Program
    {   /*3.A vehicle has four wheels and a color assigned to it.
        A car is a vehicle with a seating capacity of four.
        An SUV is a car which has a 800 horsepower engine. Create a model detailing the same.*/
        class Vehicle { 
            public int wheels { set; get; }
            public string color  { set; get; }

            public Vehicle(int wheels ,string color) { 
                this.wheels = wheels;
                this.color = color;
            }

            public override string ToString() {
                return $"vehicle has {wheels} wheels and color is {color}";
            }
        }

        class Car :Vehicle { 
             public int seatingCapacity { set; get; }
            public Car(int wheels ,string color,int seatingCapacity):base(wheels ,color) {
            
                this.seatingCapacity = seatingCapacity;

            }

            public override string ToString() {
                return $"seating capacity : {seatingCapacity}";
            }
            
        }

        class SUV :Car { 
             public int horsepower { set; get; }

            public SUV(int wheels,string color,int seatingCapacity,int horsepower):base(wheels,color,seatingCapacity){
                this.horsepower = horsepower;
            }

            public override string ToString()
            {
                return $"horse : {horsepower}";
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
