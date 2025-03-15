using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    /*
     3. Create a class Book with the following details : id, name , price, category
    Create  methods to CalDiscount(), CompareDiscCost() 
    Create 4 objects of books by taking the user input and then compare the cost of any 2 books
     */
    internal class Book
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public string Category { get; private set; }
        public double DiscountedPrice { get; private set; }

        public Book(int id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            DiscountedPrice = 0;
        }

        public void CalDiscount()
        {
            double discountRate = 0;

           
            switch (Category.ToLower())
            {
                case "fiction":
                    discountRate = 0.10; 
                    break;
                case "non-fiction":
                    discountRate = 0.05; 
                    break;
                case "educational":
                    discountRate = 0.15; 
                    break;
                default:
                    discountRate = 0.02; 
                    break;
            }
            DiscountedPrice = Price - (Price * discountRate);
            Console.WriteLine($"Discounted Price for \"{Name}\" is: {DiscountedPrice:C}");
        }

        public static void CompareDiscCost(Book book1, Book book2)
        {
            if (book1.DiscountedPrice == 0 || book2.DiscountedPrice == 0)
            {
                Console.WriteLine("Discount not calculated for one or both books. Calculating now...");
                book1.CalDiscount();
                book2.CalDiscount();
            }

            if (book1.DiscountedPrice < book2.DiscountedPrice)
            {
                Console.WriteLine($"\"{book1.Name}\" is cheaper than \"{book2.Name}\".");
            }
            else if (book1.DiscountedPrice > book2.DiscountedPrice)
            {
                Console.WriteLine($"\"{book2.Name}\" is cheaper than \"{book1.Name}\".");
            }
            else
            {
                Console.WriteLine($"Both books, \"{book1.Name}\" and \"{book2.Name}\", cost the same after discount.");
            }
        }
    }


}

