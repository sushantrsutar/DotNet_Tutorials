using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : IComparable
{
    public int Id;
    public string Name;
    public int Runs;

    public Player() { }
    public Player(int Id, string Name, int Runs)
    {
        this.Id = Id;
        this.Name = Name;
        this.Runs = Runs;
    }

    public override string ToString()
    {
        return $"Id : {Id} , Name : {Name} , Runs : {Runs}";
    }

    public int CompareTo(Object obj)
    {
        Player obj1= (Player)obj;

        //return this.Id.CompareTo(obj1.Id);
        //return this.Name.CompareTo(obj1.Name);
        return this.Runs.CompareTo(obj1.Runs);

    }
}
namespace ComparableDemoTQ
{
    
        internal class Program
        {
        static void Main(string[] args)
        {
            //List<Player> list = new List<Player>();
            //list.Add(new Player(1,"MS",123));
            //list.Add(new Player(3,"VK",900));
            //list.Add(new Player(2,"SS",323));
            //list.Add(new Player(5,"TS",13));
            //list.Add(new Player(4,"YC",213));

            //list.Sort();
            //foreach (Player p in list) {
            //    Console.WriteLine(p);
            //    }

            //}


            //comparer demo
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(1, "Amit", 23000));
            emplist.Add(new Employee(3, "Rita", 13000));
            emplist.Add(new Employee(2, "Priya", 33000));
            emplist.Add(new Employee(5, "Suraj", 3000));
            emplist.Add(new Employee(4, "Samir", 1000));
            Console.WriteLine("Original List");
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();

            Console.WriteLine("Sort By Id ");
            emplist.Sort(new Idcompare());
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("Sort By Name");
            emplist.Sort(new Namecompare());
            foreach (Employee emp in emplist) {
                Console.WriteLine(emp);    
            }

            Console.WriteLine("Sort by Salary");
            emplist.Sort(new SalaryCompare());
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }

        }

    }
    
}
