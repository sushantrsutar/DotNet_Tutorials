using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in str)
            {
                int count = 0;
                if (charCount.ContainsKey(c))
                {
                    count = charCount[c];
                }
                count++;
                charCount[c] = count;
            }
            foreach (var item in charCount)
            {
                Console.WriteLine(item.Key + ":" + item.Value);

            }

            //find second highest from arry
            int[] arr = { 2, 1, 3, 4, 9, 5, 6,7 ,8 };
            foreach (int i in arr) {
                Console.Write(i+" ");
            }
            int high=arr[0];
            int secondHigh=arr[1];
            foreach (var item in arr) {
                if (item > high)
                {
                    secondHigh = high;
                    high = item;
                }
                else if (item > secondHigh && item < high) {
                    secondHigh = item;

                }
            }
            Console.WriteLine("\nSecond Highest number : "+secondHigh);

        }
    }
}
