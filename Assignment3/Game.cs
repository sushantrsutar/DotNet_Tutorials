using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{   /*"1.Create a class Game having the method rules() and noOfPlayers(). Create a class BasketBall, Soccer, Cricket
    which are child class of Game. Override the above methods and use method overriding
    to show thw rules and noofPlayers according to the object passed
    */
    public  class Game
    {
        public virtual void Rules() {
            Console.WriteLine("genral game rules.");
        }

        public virtual void noOfPlayers() {
            Console.WriteLine("number of players.");
        }
    }

    public class BasketBall : Game
    {
        public override void Rules() {
            Console.WriteLine("Basket ball rules");
        }
        public override void noOfPlayers()
        {
            Console.WriteLine("Players in basket ball");
        }
    }

    public class Soccer : Game 
    {
        public override void Rules() {
            Console.WriteLine("rules in Soccer");
        }
        public override void noOfPlayers()
        {
            Console.WriteLine("Players in Soccer"); ;
        }
    }

    public class Cricket : Game 
    {
        public override void Rules()
        {
            Console.WriteLine("rules in Cricket"); ;
        }
        public override void noOfPlayers()
        {
            Console.WriteLine("Players in Cricket"); ;
        }
    }
}
