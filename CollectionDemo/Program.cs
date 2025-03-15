using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        public static void printList(List<int> list) {
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int>list=new List<int>();
            list.Add(111);
            list.Add(5);
            list.Add(3);
            list.Add(2);
            list.Add(10);
            printList(list);
            
            //list.Sort();
            //printList(list);

            //list.Reverse();
            //printList(list);

            list.Clear();
            printList(list);
        
        }
    }
}
