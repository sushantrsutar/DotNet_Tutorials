using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Test
{
 /*1 Write a program to create a class named Vehicle having protected instance variables regnNumber,
 * speed, color, ownerName and a method showData ( ) to show “This is a vehicle class”. 
 * Inherit the Vehicle class into subclasses named Bus and Car having individual private instance variables
 * routeNumber in Bus and manufacturerName in Car and both of them having showData ( ) method showing
 * all details of Bus and Car respectively with content of the super class’s showData ( ) method.*/
    internal class Vehicle
    {
        private string regnNumber;
        protected int Speed;
        protected string Color;
        protected string OwenerName;
        protected string RegnNumber;

        public Vehicle(string RegnNumber, int Speed, string Color, string OwenerName) { 
            this.RegnNumber = RegnNumber;
            this.Speed = Speed;
            this.Color = Color;
            this.OwenerName = OwenerName;
        }
        public string ShowData() {
            return ($"RegnNumber : {RegnNumber} , Speed : {Speed} , Color : {Color} , Owener Name : {OwenerName}");
        }
    }

    class Bus : Vehicle 
    {
        private int routeNumber { set; get; }
        public Bus(string RegnNumber, int Speed, string Color, string OwenerName, int routeNumber): base(RegnNumber,Speed,Color,OwenerName)
        { 
            this.routeNumber = routeNumber;
        }

        public string ShowData() {
            return base.ShowData() + $", routeNumber : {routeNumber}";
        }

    }

    class Car : Vehicle
    {
        private string manufacturerName;

        public Car(string RegnNumber, int Speed, string Color, string OwenerName, string manufacturerName):base(RegnNumber, Speed, Color, OwenerName)
        {
            this.manufacturerName = manufacturerName;
        }
    
        public string  ShowData() {
            return base.ShowData() + $", manufacturerName : {manufacturerName}";
        }
    }
}
