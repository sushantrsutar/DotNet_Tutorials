using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTestPractice
{
    internal class Program
    {
        public static void printNumber(int x, int y)
        {
            foreach (int i in Enumerable.Range(x, y))
            {
                Console.Write(i + " ");
            }
        }

        static void printEvenNum(int a, int b)
        {
            for (int i = a; i <=b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void printArray(int[] arr) {
            foreach (int i in arr) {
                Console.Write(i+" ");
            }
        }

        static void reverseArray(int[] arr) {
            for (int i = arr.Length-1; i >= 0; i--) {
                Console.Write(arr[i]+" ");
            }
        }

        static void findFactorial(int n) {
            int fact = 1;
            for (int i = 1; i <= n; i++) { 
                fact=fact *i;
            }
            Console.WriteLine(fact);
        }

       

            static void Main(string[] args)
            {
            int[] num = { 1, 2, 3, 4, 5 };


            //printNumber(1, 100);
            //printEvenNum(10, 20);
            //printArray(num);
            //reverseArray(num);
            //findFactorial(5);

            var name = "";
            Console.WriteLine(name);
            Console.WriteLine(name.GetType()); ;
            









        }
    }
}
