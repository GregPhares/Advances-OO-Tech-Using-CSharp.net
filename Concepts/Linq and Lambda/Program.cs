using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This program is designed to show how to used Linq and lambda
/// </summary>
namespace HW8
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create a library and accessor
            Action<Book> printBook = (book) => Console.WriteLine("{0}",book.title);
            List<Book> books = new List<Book>()
            {
                new Book() { title = "The Blue Book", keywords= "colors, blue", pages = 100, price = 52.95f },
                new Book(){ title = "The Black Book", keywords= "colors, black", pages = 10, price = 59.95f },
                new Book() { title = "C# Notes", keywords= "colors, black", pages = 140, price = 9.95f },
                new Book() { title = "Iron Man", keywords = "mcu, iron man", pages = 400, price = 34.95f },
                new Book() { title = "Avengers", keywords = "mcu, avengers", pages = 700, price = 49.95f },
                new Book() { title = "Guardians of the Galaxy", keywords = "mcu, guardians, galaxy", pages = 700, price = 43.95f },
            };

            //writes out the entire library
            Console.WriteLine("The book library contains:");
            foreach(Book title in books)
            {
                printBook(title);
            }

            var bookInquiry1 = from book in books
                               select book.price;
            double bookPriceAve = bookInquiry1.Average();

            //Prints out the library average cost
            Console.WriteLine("\nThe average book price with in the library is: {0} \n", bookPriceAve);

            Console.WriteLine("Books that cost less than $50.00 include:");

            var bookInquiry2 = from book in books
                              where book.price < 50
                              orderby book.title ascending
                              select book;
            
            //Prints out the books having topics with MCU

            bookInquiry2.ToList().ForEach(book => Console.WriteLine(book.title));
            Console.WriteLine("\nThe books about the MCU are:");

            var bookInquiry3 = from book in books
                               where book.keywords.Contains("mcu")
                               orderby book.title ascending
                               select book;

            bookInquiry3.ToList().ForEach(book => Console.WriteLine(book.title));
                              

            
        }
        class Book
        {
            public string title;
            public string keywords;
            public float price;
            public int pages;
        }
    }
    
}
