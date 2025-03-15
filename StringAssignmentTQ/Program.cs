using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringAssignmentTQ
{


//8.Check whether String is Anagram.
 


//12.Write a C# program to toggle case of each character of a stringCompare two Strings using == and Equals()
//On words:




//5.Write a C# program to toggle case first character of every word  of a string.
    internal class Program
    {
        //1.Show alternate character form String from reverse.
        public static void ShowAltCharRevStr(string str) {
            for (int i = str.Length - 1; i >= 0; i = i - 2) {
                Console.Write(str[i]);
            }
        }

        //2.Calculate no of vowels, consonants, digits and special symbol from given String
        public static void CalVowelDigitsSymbol(string str) {
            Console.WriteLine(str +"\n");
            int vowels = 0;
            int consonants = 0;
            int digits = 0;
            int specialSymbol = 0;
            string vowelsChar = "AEIOUaeiou";
            foreach (Char ch in str) {
                if (char.IsLetter(ch))
                {
                    if (vowelsChar.Contains(ch))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (char.IsDigit(ch))
                {
                    digits++;
                }
                else { 
                    specialSymbol++;
                }
                
            }
            Console.WriteLine($"vowels : {vowels} \nconsonants : {consonants} \ndigits : {digits} \nspecialSymbol : {specialSymbol}");
        }

        //3.Check occurrences of particular  character, how many times it’s there and which diff positions.
        public static void OccuranceOfChar() {
            Console.Write("Enter String : ");
            string str=Console.ReadLine();
            Console.Write("Enter Character to search : ");
            Char ch = Console.ReadLine()[0];
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == ch) {
                    count++;
                    //Console.Write(i+" ");
                    list.Add(i);
                }
            }
            Console.Write($"'{ch}' Found At Index : ");
            foreach (int i in list) {
                Console.Write(i+",");
            }
            Console.WriteLine($"\nOccurrences character '{ch}': {count}");
        }
        //5.Write a C# program to convert lowercase string to uppercase.

        public static void LowerToUpper(string str) {
            Console.WriteLine($"Original string : {str}");
            string UpperString=str.ToUpper();
            Console.WriteLine($"String in upper case : {UpperString}");
        }

        //6.Show occurrence of each character from String
        public static void OccuranceOfChar(string str)
        {
            Console.WriteLine($"String : {str}");
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (char ch in str)
            {
                if (frequency.ContainsKey(ch))
                {
                    frequency[ch]++;
                }
                else
                {
                    frequency[ch] = 1;
                }
            }

            foreach (var enty in frequency)
            {
                Console.WriteLine($"{enty.Key}:{enty.Value}");
            }
        }

        //7.Check whether String is palindrome.
        public static void IsPalindrome(string str) {
            string revStr = "";
            for (int i = str.Length - 1; i >= 0; i--) { 
                revStr=revStr + str[i];
            }
            if (revStr.Equals(str))
            {
                Console.WriteLine($"'{str}' is Palindrome String");
            }
            else {
                Console.WriteLine($"'{str}' is not Palindrome String");
            }
        }

        //9.Replace the particular word from string by another string.
        public static void ReplaceWorld() {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            string newString=input.Replace(oldWord, newWord);
            Console.WriteLine("Updated string: " + newString);
        }

        //10.Check entered String is valid mobile number.
        public static void ValidMobileNum(String num) {
            /*string pattern → Declares a variable pattern of type string to store the regular 
             expression (Regex) pattern.
            "^[6789]\\d{9}$" → This regex pattern is used to validate mobile numbers.
            Let's break it down:
            ^ → Ensures the match starts from the beginning of the string.
            [6789] → Ensures the first digit is 6, 7, 8, or 9.
            \\d{9} → Ensures the next 9 characters are digits (0-9).
            \\d → Matches any digit (0-9).
            {9} → Ensures that the preceding pattern (\\d) appears exactly 9 times.
            $ → Ensures the match ends at the last digit (i.e., the number must be exactly 
            10 digits long with no extra characters).*/
            string pattern = "^[6789]\\d{9}$";
            if (Regex.IsMatch(num, pattern))
            {
                Console.WriteLine($"{num} is valid Mobile Number");
            }
            else {
                Console.WriteLine("Not Valid Mobile Number");
            }
        }
        //11.Write a C# program to find highest frequency character in a string.
        public static void HighFreqChar(string str) { 
            Console.WriteLine($"Input : {str}");
            Dictionary<char , int >charCount= new Dictionary<char , int>();
            foreach (var ch in str)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else {
                    charCount[ch] = 1;
                }
            }
            char maxChar = ' ';
            int maxCount = 0;
            foreach (var entry in charCount) {
                if (entry.Value > maxCount) { 
                    maxCount= entry.Value;
                    maxChar= entry.Key;
                }
            }
            Console.WriteLine($"Maximum reapeated character '{maxChar}' , And Count is : {maxCount}");
        }

        //1. Reverse the string word by word
        public static void ReverseStringWordToword(string str)
        {
            Console.WriteLine($"Original String : {str}");
            string[] word=str.Split(' ');
            Console.WriteLine("Reverse String : ");
            for (int i = word.Length - 1; i >= 0; i--) {
                Console.Write(word[i]+" ");
            }
        }

        //2. Write a program to sort string arrays on the basis of length and if length is same
        //    then lexicographically
        public static void SortStringArray(string[] arr) {
            foreach (string str in arr) {
                Console.Write(str+" ");
            }
            Console.WriteLine();
            int n = arr.Length;
            for (int i=0;i<n-1;i++) {
                for (int j = 0; j < n - i-1; j++) {
                    if (arr[j].Length > arr[j + 1].Length-1) { 
                        string temp= arr[j];
                        arr[j]=arr[j + 1];
                        arr[j+1]=temp;
                    }
                }
            }
            Console.WriteLine("Sort By Length: ");
            foreach (string str in arr)
            {
                Console.Write(str + " ");
            }
        }

        //3.WAP to find the most repeated word in a string
        public static void MostReapetedWordInString(string str) {
            Console.WriteLine($"Original String : {str}");
            string[] words=str.Split(' ');
            Dictionary<string,int>wordCount= new Dictionary<string,int>();
            foreach (string word in words) {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else {
                    wordCount[word] = 1;
                }
            }
            foreach (var entry in wordCount) {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

        }

        //4.Take two string arrays and find the common elements between them
        public static void CommonStrings(string[] arr1, string[] arr2) {
            foreach (string str in arr1) { Console.Write(str+" "); }
            Console.WriteLine();
            foreach (string str in arr2) { Console.Write(str + " "); }

            var CommonStrings = arr1.Intersect(arr2).ToArray();
            foreach (string str in CommonStrings) {
                if (CommonStrings.Length > 0) {
                    Console.WriteLine(str);
                }
            }
        }
        static void Main(string[] args)
        {
            //string str = "abcdefg";
            //Console.WriteLine(str);
            //Console.WriteLine();

            //ShowAltCharRevStr (str);
            //CalVowelDigitsSymbol("fsaeiouhgf@#12425");
            //OccuranceOfChar();
            //LowerToUpper("sushant");
            //OccuranceOfChar("sushant");
            //IsPalindrome("Dad");
            //ReplaceWorld();
            //ValidMobileNum("7812345255");
            //HighFreqChar("dasdasssshgh");
            //ReverseStringWordToword("I am sushant");

            //string[] words = { "apple", "banana", "cherry", "date", "kiwi", "fig", "grape", "mango", "pear", "apricot" };
            //SortStringArray(words);

            //MostReapetedWordInString("Hello world! The world is beautiful. The world is vast and full of opportunities");

            string[] array1 = { "apple", "banana", "cherry", "date", "kiwi" };
            string[] array2 = { "kiwi", "orange", "cherry", "pear", "grape" };
            CommonStrings(array1, array2);
        }
    }
}
