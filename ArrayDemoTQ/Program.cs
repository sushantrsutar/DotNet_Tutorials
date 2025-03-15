using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
2. Frequency of all elements, unique and duplicate elements in an array
3. Pair of elements in arrays whose sum is equivalent to given number
5. second highest number w/o sorting
7.WAP to left rotate the array
    ar={1,2,3,4,5}
    o/p: {3,4,5,1,2}
8.WAP to replace the negative elements in an array with immendiate left elements square
    ar={1,2,-3,2,-4,-6}
    o/p={1,2,4,2,4,16}
    here -> -3 is replaced by square of 2 which is 4
9. Shift all zeros in the beginning of array/ Shift zeros at end
10. Shift even before odd 
11. Shift negative before positive in array
12.Find the common elements between the two arrays

14.Write a C# program to find a missing number in an array. Means e.g. array has 1 
to n element in sequence(n can be 50 or 100) arr[] = [1, 2, 3, 4, 6, 7] So missing no is 
5 


2.WAP to put even and odd elements of array in two separate arrays.

4.WAP to find and count total number of duplicate elements in an array.
5.WAP to print all unique elements in the array.


7.WAP to count frequency of each element in an array.
8.WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
9.WAP sort array elements in ascending order.
10.WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] without using tempor------ary array.



1.WAP to take array and to merge or concatenate them and store the result into another array.
Input: arr1[] = { 1, 3, 4, 5}, arr2[] = {2, 4, 6, 8}
Output: arr3[] = {1, 3, 4, 5, 2, 4, 6, 8}

2.WAP to take array and to merge or concatenate them and store the result into another array.but if both arrays having same value , in new array do not repeat that
Input: arr1[] = { 1, 3, 4, 5,6}, arr2[] = {3,2, 4, 6, 8}
Output: arr3[] = {1, 3, 4, 5, 2, 4, 6, 8}


3.WAP to take array and to merge or concatenate them and store the result into another array. 
note:first element from 1st array and 2nd element from 2nd array as so on..
Input: arr1[] = {1,2,3,4}, arr2[] = {11,22,33,44,55,66}
Output: arr3[] = {1,11,2,22,3,33,4,44,55,66}

4.WAP to take array and to merge or concatenate them and store the result into another array.
Input: arr1[] = {1,2,3,4,5,6,7}, arr2[] = {11,22,33,44}
Output: arr3[] = {1,11,2,22,3,33,4,44,5,6,7}


5.WAP to take array and to merge or concatenate them and store the result into another array.
Input: arr1[] = {1,2,3,4}, arr2[] = {5,6,7,8,9,10}
Output: arr3[] = {1,6,3,8,9,10}
*/
namespace ArrayDemoTQ
{
    internal class Program
    {   
        public static void PrintArr(int[] arr) {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //6.WAP to find the second max element in an array.
        public static void SecondMaxElement(int[] arr) {
            //int SecondMax = 0;
            //SortArray(arr);
            //SecondMax = arr[arr.Length - 2];
            //return SecondMax;

            int FirstMax = arr[0];
            int SecondMax = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > FirstMax)
                {
                    SecondMax = FirstMax;
                    FirstMax = arr[i];
                    
                   
                }
                else if (FirstMax != SecondMax && SecondMax < arr[i]) { 
                    SecondMax = arr[i];

                }
            }
            Console.WriteLine("Second Max Element : "+SecondMax);
        }

        ////7.WAP to find the second smallest element in an array
        public static void SecondSmallestElement(int[] arr) { 
            int FirstMin=arr[0];
            int SecondMin=arr[0];
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < FirstMin) { 
                    SecondMin=FirstMin;
                    FirstMin = arr[i];
                }
                else if (FirstMin != SecondMin && SecondMin < arr[i])
                {
                    SecondMin = arr[i];

                }
            }
            Console.WriteLine("Second MIn Element : " + SecondMin);
        }
            

        //1.WAP to print all negative elements in an array and also count total number of negative elements in an array.
        public static void PrintNegetiveNumber(int[] arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 1) {
                    Console.WriteLine(arr[i]);
                    count++;
                }
            }
            Console.WriteLine("Total Negetive Numbers : "+count);
        }

        //1. Traverse the array and find the sum of odd elements in an array
        public static int SumOfOddElements(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 != 0) { 
                sum += arr[i];
                }
            }
            return sum;
        }

        //2. Print cube of each number in array
        public static int[] FindQube(int[] arr) {
            for (int i = 0; i < arr.Length; i++) { 
                arr[i] = arr[i] * arr[i] * arr[i];
            }
            return  arr;
        }

        //3. Search the element in an array
        public static bool SearchElement(int[] arr,int n) {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == n) { 
                    return true;
                }
            }
            return false;
        }

        //4. Find the maximum number in an array
        public static int FindMaxNumInArray(int[] arr) {
            int max = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) { 
                    max = arr[i];
                }
            }
            return max;
        }
        //3.WAP to find the maximum and minimum value in an array.
        public static int FindMinNumInArray(int[] arr) {
            int min = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < min) { 
                    min=arr[i];
                }
            }
            return min;
        }

        //5. Reverse the array
        public static void ReverseArray(int[] arr) {
            for (int i = arr.Length-1; i >= 0; i--) {
                Console.Write(arr[i]+" ");
            }
        }

        //public static int[] ReverseArray(int[] arr)
        //{
        //    int[] revArray = new int[arr.Length];
        //    for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
        //    {
        //        revArray[j] = arr[i];
        //    }
        //    return revArray;
        //}

        //6. Print the alternate numbers of an array
        public static void PrintAlternateNumber(int[] arr) {
            for (int i = 0; i < arr.Length; i = i + 2) {
                Console.Write(arr[i]+" ");
            }
        }

        //1. Sum of prime number in array
        public static bool IsPrimeNum(int n) {
            if (n <= 1)
            {
                return false;
            }
            else {
                for (int i = 2; i <= Math.Sqrt(n); i++) {
                    if (n % i == 0) {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int SumOfPrimeNumber(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (IsPrimeNum(arr[i])) { 
                    sum += arr[i];
                }
            }
            return sum;
        }
        //4. Sort an array
        public static void SortArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length-1 - i; j++) {
                    if (arr[j] > arr[j + 1]) { 
                        temp = arr[j];
                        arr[j]=arr[j + 1];
                        arr[j+1]=temp;
                    }
                }
            }
        }

        //5. second highest number w/o sorting
        public static int SecondHighNum(int[] arr) {
            int SecondHighNum = 0;
            SortArray(arr);
            SecondHighNum = arr[arr.Length-2];
            return SecondHighNum;
        }

        //6.WAP to half sort the array in ascending and half in descending
        public static void HalfSortArray(int[] arr) {
            SortArray(arr);
            for (int i = 0; i <= arr.Length / 2; i++) {
                Console.Write(arr[i]+" "); 
            }
            for (int j = arr.Length - 1; j >= arr.Length / 2; j--) {
                Console.Write(arr[j]+" ");
            }
        }

        ////13. Print alternate prime number in an array
        //public static void PrintAlternatePrime(int[] arr) {
        //    for (int i = 0; i < arr.Length; i++) {
        //        if (IsPrimeNum(arr[i])) {
        //            Console.Write(arr[i]+" ");
        //        }
        //    }
        //}



        //15.WAP to shuffle array. Means e.g. arr[] = [5, 6, 23, 67, 39, 10, 2]  
        //So output array is [6, 23, 67, 39, 10, 2, 5].
        public static void SuffleArray(int[] arr) { 
            int firstEle=arr[0];
            for (int i = 0; i < arr.Length-1; i++) {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = firstEle;
        }

        public static int SearchEle(int[] arr, int num) { 
            return Array.IndexOf(arr, num);

        }

        //merge array
        public static int[] MergeArr(int[] arr1, int[] arr2) {
            int[] MergeArr=new int[arr1.Length+arr2.Length];
            int index = 0;
            for (int i = 0; i < arr1.Length; i++) { 
                MergeArr[index++] = arr1[i];
                MergeArr[index++] = arr2[i];
            }

            return MergeArr;
        }

        public static int[] SecondMerge(int[] arr1, int[] arr2) {
           
            for (int i = 0; i < arr1.Length; i=i+2) {
                arr1[i]=arr2[i];
            }
            return arr1;
            
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 21, 23, 34, 35, 16, 7, 18, 98, 10, 11, 12 };
            //int[] arr = { -1, -2, -3, 4, 5,10,9,8,7,11 };
            //PrintArr(arr);



            //Array methods
            //Array.Sort(arr);
            //PrintArr(arr);
            //Array.Reverse(arr);
            //PrintArr(arr);
            //Array.Resize(ref arr,5);
            //PrintArr(arr);

            //int[] arr2=new int[arr.Length];
            //Array.Copy(arr,arr2,arr.Length);
            //PrintArr(arr2);

            //Array.Clear(arr2, 3, 3);
            //PrintArr(arr2);

            //Console.WriteLine("Enter number : ");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int result=SearchEle(arr, num);
            //if (result != -1)
            //{
            //    Console.WriteLine($"{num} present at index {result} ");
            //}
            //else {
            //    Console.WriteLine($"{num} not present");
            //}



            ////1. Traverse the array and find the sum of odd elements in an array
            //int sum=SumOfOddElements(arr);
            //Console.WriteLine("Sum of Odd elements : "+sum);

            ////2.Print cube of each number in array
            //int[] qubeArr=FindQube(arr);
            //PrintArr(qubeArr);

            ////3. Search the element in an array
            //Console.WriteLine(SearchElement(arr,12));

            ////4. Find the maximum number in an array
            //Console.WriteLine("Maximum number : "+FindMaxNumInArray(arr));

            ////5.Reverse the array
            //int[] revArr=ReverseArray(arr);
            //PrintArr(revArr);
            //ReverseArray(arr);

            ////6. Print the alternate numbers of an array
            //PrintAlternateNumber(arr);

            //1. Sum of prime number in array
            //Console.WriteLine(IsPrimeNum(5));
            //Console.WriteLine("Sum Of Prime Number : "+ SumOfPrimeNumber(arr));

            ////4. Sort an array
            //SortArray(arr);
            //PrintArr(arr);

            ////5. second highest number w/o sorting
            //Console.WriteLine(SecondHighNum(arr)); ;

            ////6.WAP to half sort the array in ascending and half in descending
            //HalfSortArray(arr);

            //13. Print alternate prime number in an array
            //PrintAlternateNumber(arr);


            ////user input
            //Console.WriteLine("Enter Size : ");
            //int size=Convert.ToInt32(Console.ReadLine());
            //string[] subject=new string[size];
            //Console.WriteLine($"Enter {size} subjects");
            //for (int i = 0; i <= size-1; i++) {
            //    //Console.WriteLine($"Enter {i} subject : ");
            //    subject[i]= Console.ReadLine();
            //}
            //Console.WriteLine(" ");
            //foreach (string s in subject) {
            //    Console.WriteLine(s);
            //}

            //Suffel array elements
            //SuffleArray(arr);
            //PrintArr(arr);


            //1.WAP to print all negative elements in an array and also count total number of negative elements in an array.
            //PrintNegetiveNumber(arr);

            //3.WAP to find the maximum and minimum value in an array.
            //Console.WriteLine("minimun number : "+ FindMinNumInArray(arr));

            ////6.WAP to find the second max element in an array.
            //Console.WriteLine("Second Max Element :"+SecondMaxElement(arr));

            //SecondMaxElement(arr);

            //7.WAP to find the second smallest element in an array
            //SecondSmallestElement(arr);

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 11, 22, 33, 44, 55 };
            //PrintArr(arr1);
            //PrintArr(arr2);

            ////PrintArr(MergeArr(arr1, arr2));
            //PrintArr(SecondMerge(arr1, arr2));

            //Employee has same salary and high salary
            //Employee employee = new Employee(1,"Sushant",2000,new string[] { "java", "python"});
            //Console.WriteLine(employee);


            /*"1.WAP to print the employees from Employee[] array who has same salary 
             * (Create Employee class which has 3 attributes id, name, salary, skill[]
             * and add employee objects to your array)
                Find the employee with highest salary*/
            Employee[] employees = {
                new Employee(1,"Sushant",20000,new string[]{"Java","Python"}),
                new Employee(2,"Neha",30000,new string[]{"JS","Sql"}),
                new Employee(3,"Priya",20000,new string[]{"TS","Python"}),
                new Employee(4,"Suraj",40000,new string[]{"HTML","Python"}),
                new Employee(5,"Amit",800000,new string[]{"Java","CSS"})

            };
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //high salary emp
            Employee HighSalaryEmp=employees[0];
            foreach (var emp in employees) {
                if (emp.EmpSalary > HighSalaryEmp.EmpSalary)
                {
                    HighSalaryEmp = emp;
                }
            }
            Console.WriteLine($"Employee Have Highest Salary : {HighSalaryEmp}");

            //same salary emp
            


        }
    }
}
