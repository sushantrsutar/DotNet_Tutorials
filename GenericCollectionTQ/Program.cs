using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionTQ
{
    public class Player{
        public int Id;
        public string Name;
        public int Runs;
        public Player(int Id,string Name,int Runs) {
            this.Id = Id;
            this.Name = Name;
            this.Runs = Runs;
        }

        public override string ToString() {
            return $"Id : {Id} , Name : {Name} , Runs : {Runs}";
        }
    }

    public class Team:IEnumerable {
        Player[] player;

        public Team() {
            Player[] player = { 
                new Player(1,"Virat",78),
                new Player(2,"Msd",90),
                new Player(3,"Yuvi",99)
            };
        }

        public IEnumerator GetEnumerator() { 
            return player.GetEnumerator();
        }
    }
    internal class Program
    {
        public static void PrintList(List<string> list) {
            Console.WriteLine();
            foreach (string name in list)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }

        public static void PrintDictionary(Dictionary<int, string> dict) {
            Console.WriteLine();
            foreach (KeyValuePair<int, string> k in dict) {
                Console.WriteLine(k.Key+" : "+k.Value);
            }

            Console.WriteLine();
        }

        public static void PrintSet(HashSet<int> set) {
            Console.WriteLine();
            foreach (int i in set)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string>names = new List<string>();
            names.Add("Amit");
            names.Add("Suraj");
            names.Add("Neha");
            names.Add("Priya");
            names.Add("Sushant");
            names.Add("Rishi");

            //PrintList(names);
            //Console.WriteLine(names.Capacity);
            //Console.WriteLine(names.Count);
            //names.Sort();
            //PrintList(names);
            //names.Reverse();
            //PrintList(names);
            //names.RemoveAt(1);
            //PrintList(names);
            //names.Insert(1, "Maya");
            //PrintList(names);

            //Dictionary
            //Dictionary<int,string> emp=new Dictionary<int,string>();
            //emp.Add(1, "Ram");
            //emp.Add(2, "Neha");
            //emp.Add(3, "Raj");
            //emp.Add(4, "Disha");
            //emp.Add(5, "Sharu");
            //PrintDictionary(emp);

            //string name = emp[1];
            //Console.WriteLine(name);
            //emp.Remove(2);
            //PrintDictionary(emp);
            //Console.WriteLine(emp.ContainsKey(1)); 

            /*create Dictionary with empid as a key and depatment name as a value . 
             * create another Dictionary showing name of dept as key and no of working employee as values*/

            //Dictionary<int, string> dept = new Dictionary<int, string>();
            //dept.Add(1, "IT");
            //dept.Add(2, "HR");
            //dept.Add(3, "IT");
            //dept.Add(4, "HR");
            //dept.Add(5, "IT");
            //dept.Add(6, "DE");

            //Dictionary<string, int> empCount = new Dictionary<string, int>();

            //foreach (string d in dept.Values)
            //{
            //    if (empCount.ContainsKey(d))
            //    {
            //        empCount[d]++;
            //    }
            //    else
            //    {
            //        empCount[d] = 1;
            //    }
            //}

            


            //PrintDictionary(dept);

            //foreach (KeyValuePair<string, int> k in empCount)
            //{
            //    Console.WriteLine(k.Key + " : " + k.Value);
            //}


            //HashSet<int> numbers = new HashSet<int>();
            //HashSet<int> num2 = new HashSet<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(1);
            //numbers.Add(2);

            //PrintSet(numbers);
            //numbers.Remove(1);
            //PrintSet(numbers);
            //Console.WriteLine(numbers.Contains(3));
            //numbers.Add(12);
            //numbers.Add(13);
            //PrintSet(numbers);
            //List<int> list = new List<int>(numbers);
            //list.Sort();
            //foreach (int i in list) {
            //    Console.Write(i+ " ");
            //}


            //math operation using set
            //HashSet<int> set1 = new HashSet<int>();
            //set1.Add(1);
            //set1.Add(2);
            //set1.Add(3);
            //set1.Add(4);
            //set1.Add(5);

            //HashSet<int> set2 = new HashSet<int>();
            //set2.Add(3);
            //set2.Add(4);
            //set2.Add(6);
            //set2.Add(9);
            //set2.Add(5);

            //PrintSet(set1);
            //PrintSet(set2);
            //Console.WriteLine("Union with"); 
            //set1.UnionWith(set2);
            //PrintSet(set1);

            //Console.WriteLine("ExceptWith");
            //set1.ExceptWith(set2);
            //PrintSet(set1);

            //Console.WriteLine("IntersectWith");
            //set1.IntersectWith(set2);
            //PrintSet(set1);

            //Console.WriteLine(set1.Average()); 


            //genric queue
            //Queue<int>num= new Queue<int>();
            //num.Enqueue(1);
            //num.Enqueue(2);
            //num.Enqueue(3);
            //num.Enqueue(6);
            //num.Enqueue(5);
            //num.Enqueue(4);
            //foreach (int i in num)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            ////num.Dequeue();
            ////num.Clear();
            ////Console.WriteLine(num.Peek());

            //Console.WriteLine(num.Contains(1)); ;
            //foreach (int i in num) {
            //    Console.Write(i+" ");
            //}

            //stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //foreach (int i in stack)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(stack.Pop());

            //foreach (int i in stack) {
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(stack.Count());

            /*Implement country code & country name using Hashtable
            Implement dept id , dept name using SortedList*/
            //Hashtable countryTable = new Hashtable();
            //countryTable.Add("IN", "India");
            //countryTable.Add("PK", "Pakistan");
            //countryTable.Add("CA", "Canada");
            //Console.WriteLine("Country code and country name (Hashtable)");
            //foreach (DictionaryEntry entry in countryTable) {
            //    Console.WriteLine(entry.Key+":"+entry.Value);
            //}

            //SortedList deptList = new SortedList();
            //deptList.Add(101, "HR");
            //deptList.Add(102, "IT");
            //deptList.Add(103, "Finance");

            //Console.WriteLine("Department ID and Department Name (SortedList):");
            //foreach (DictionaryEntry entry in deptList)
            //{
            //    Console.WriteLine(entry.Key + " : " + entry.Value);
            //}


            //foreach working
            //List<string>list = new List<string>();
            //list.Add("Amit");
            //list.Add("Neha");
            //list.Add("Suraj");
            

            //var name=list.GetEnumerator();

            //var n1=name.MoveNext();
            //Console.WriteLine(n1);
            //Console.WriteLine(name.Current);

            //var n2=name.MoveNext();
            //Console.WriteLine(n2);
            //Console.WriteLine(name.Current);

            //var n3=name.MoveNext();
            //Console.WriteLine(n3);
            //Console.WriteLine(name.Current);

            //var n4=name.MoveNext();
            //Console.WriteLine(n4);
            //Console.WriteLine(name.Current);

            //using while loop
            //while (name.MoveNext()) {
            //    Console.WriteLine(name.Current);
            //}


            ////custom collection
            //Team team=new Team();
            //foreach (Player t in team) {
            //    Console.WriteLine(t);
            //}





















        }
    }
}
