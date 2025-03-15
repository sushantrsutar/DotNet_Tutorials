using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /*1.Write a C# program to create a base class Shape with a method called CalculateArea().
     *  Create three subclasses: Circle, Rectangle, and Triangle.
     *  Override the CalculateArea() method in each subclass to calculate and return the shape's area.*/
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape 
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        { 
            return Math.PI * radius*radius;
        }
    }

    public class Rectangle : Shape
    { 
        public double length { get; set; }
        public double width { get; set; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    public class Triangle : Shape
    { 
        public double @base { set; get; }
        public double length { set; get; }

        public Triangle(double @base, double length)
        {
            this.@base = @base;
            this.length = length;
        }

        public override double CalculateArea()
        {
            return 0.5*(@base * length);
        }
    }
}
