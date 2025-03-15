using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoTQ
{
    internal class Program
    {   
        public static void PrintHashtable(Hashtable hashtable)
        {
            Console.WriteLine();
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
            Console.WriteLine();
        }

        public static void PrintSortedList(SortedList sort) {
            Console.WriteLine();
            foreach (DictionaryEntry entry in sort) {
                Console.WriteLine(entry.Key+" : "+entry.Value);
            }
            Console.WriteLine();
        }

       
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "one");
            hashtable.Add(2, "two");
            hashtable.Add(3, "three");

           //PrintHashtable(hashtable);
            //hashtable.Remove(1);
            //Print(hashtable);
            //Console.WriteLine(hashtable.Count);
            //Console.WriteLine(hashtable.ContainsKey("one"));
            //Console.WriteLine(hashtable.ContainsValue("1"));

            SortedList sort=new SortedList(hashtable);
            //foreach (DictionaryEntry entry in sort) {
            //    Console.WriteLine(entry.Key+" : "+entry.Value);
            //}

            //Print(sort);
            //PrintSortedList(sort);

            Hashtable h1 = new Hashtable();
            h1.Add(101, "css");
            h1.Add(102, "java");
            h1.Add(103, "css");
            h1.Add(104, "c++");
            h1.Add(105, "css");

            PrintHashtable(h1);

            //table from table
            int count = 0;
            Hashtable h2 = new Hashtable();
            foreach (DictionaryEntry entry in h1) {
                if (h2.ContainsKey(entry.Value))
                {
                    //Console.WriteLine("h2 value : " + h2[entry.Value]);
                    count = Convert.ToInt32(h2[entry.Value]);
                    count++;
                    h2[entry.Value]=count;
                }
                else {
                    h2.Add(entry.Value, 1);
                }
            }

           PrintHashtable(h2);

        }
    }
}
