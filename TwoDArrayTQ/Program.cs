using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrayTQ
{
    internal class Program
    {
        public static void Print(int[,] arr) {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        //1. WAP to print minimum in rows. Means e.g. arr[][] = {{22, 31, 9}, {12, 25, 16}} output is: 9 and 12.  
        public static void MinInRow(int[,] arr) {
            for (int i = 0; i < arr.GetLength(0); i++) { 
                int min=arr[i,0];
                for (int j = 0; j < arr.GetLength(1); j++) {
                    if (arr[i, j] < min) { 
                        min= arr[i, j];
                    }
                }
                Console.WriteLine($"Min in rows : {i+1}:{min}");
            }
        }


        //2. WAP to print maximum in columns. Means e.g. arr[][]= {{22, 31, 9}, {12, 5, 16}, {34, 42, 2}}
        //        output is: 34, 42, and 16.  
        public static void MaxInCol(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            { 
                int max = arr[0, i]; 
                for (int j = 1; j < arr.GetLength(0); j++)
                { 
                    if (arr[j, i] > max)
                    {
                        max = arr[j, i]; 
                    }
                }
                Console.WriteLine($"Max in column {i + 1}:{max}");
            }
        }

        //3. WAP to print minimum in columns. Means e.g. arr[][]={{22, 31, 9}, {12, 5, 16}, 
        //        {34, 42, 2}} output is: 12, 5, 2.  
        //4.WAP to create transpose of a matrix (transpose is converting rows to columns) and print it.
        //5. WAP to subtract two matrices.
        //6.WAP to find sum of each row and column of a matrix.
        static void Main(string[] args)
        {
            //int[,] mat = new int[2, 2];
            //int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 },{7,8,9} };
            //Print(mat);

            //Console.WriteLine();
            //for (int i = 0; i < mat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat.GetLength(1); j++)
            //    {
            //        Console.Write($"mat[{i}][{j}] => {mat[i,j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //taking input
            Console.WriteLine("Enter rows : ");
            int row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter col : ");
            int col=Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[row, col];
            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    Console.WriteLine($"Enter Elements  mat[{i},{j}]");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Print(mat);
            MinInRow(mat);
            MaxInCol(mat);




        }
    }
}
