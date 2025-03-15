using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoTQ
{
    public class BookNotFoundException : Exception 
    {
        public BookNotFoundException( string errormsg):base(errormsg) { }
    }

    public class Book {
        public void findBook(int bookId) {
            if (bookId < 100)
            {
                throw new BookNotFoundException("Book not found ,check book id");
            }
            else {
                Console.WriteLine($"book found with id {bookId}");
            }
        }
    }
}
