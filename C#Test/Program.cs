using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Test

{   /*3.Create an interface called Player. The interface has an abstract method called play() 
     * that displays a message describing the meaning of “play” to the class. 
     * Create classes called Child, Musician, and Actor that all implement Player. 
     * Create an application that demonstrates the use of the classes(UsePlayer.java)*/
    interface Player {
        void Play();
    }

    public class Child : Player
    {
        public  void Play() {
            Console.WriteLine("Child playing");
        }
    }

    public class Actor : Player
    {
        public void Play() {
            Console.WriteLine("Actor Playing");
        }
    }

    public class Musician : Player
    {
        public  void Play() {
            Console.WriteLine("Musician playing");
        }
    }
    internal class Program
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool IsArmstrong(int num) { 
            int originalnum=num;
            int sum = 0;
            int digits = 0;

            while (originalnum != 0)
            {
                originalnum /= 10;
                digits++;
            }
            originalnum = num;
            while (originalnum != 0) { 
            int digit=originalnum % 10;
            sum +=(int)Math.Pow(digit,digits);
            originalnum /= 10;

            }
            return sum == num;
        }
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle("2024TATA",80,"red","Amit");
            //Console.WriteLine(vehicle.ShowData());

            //Car car = new Car("2024MARUTI",60,"black","Raj","Maruti");
            //Console.WriteLine(car.ShowData());

            //Bus bus = new Bus("2024ASHOK", 50, "black", "Ram",10);
            //Console.WriteLine(bus.ShowData());

            //Building building=new Building(2,20,4000);
            //building.ShowData();
            //----------------------------------------------------
            //House house = new House(2, 20, 4000,3,3);
            //house.ShowData();

            //Office office = new Office(2, 20, 4000, 10, 10);
            //office.ShowData();
            //--------------------------------------------------------

            //Player child = new Child();
            //child.Play();
            //Player musician = new Musician();
            //musician.Play();
            //Player actor = new Actor();
            //actor.Play();

            //---------------------------------

            //Car1 car = new Car1("Toyota","mar2032",1000000,12);
            //car.Display();
            //===================
            //prime no 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            //----------------------
            Console.WriteLine(IsArmstrong(153));
            Console.WriteLine(IsArmstrong(123));
        }
    }
}
