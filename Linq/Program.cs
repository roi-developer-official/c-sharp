using System;
using System.Linq;
namespace Linq
{
    //with LINQ you can query:
    //Objects in memory.
    //Datebases.
    //XML.
    //ADO.NET Data Sets
    partial class Program
    {

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            //LINQ Query operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;
            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book); // title of the book
            }
            //LINQ Extension methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book); // title of the book
            }
            //this will throw error if no mathing condition
            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");
            //there for
            singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); 
            if(singleBook != null)
            {
                Console.WriteLine(singleBook.Price);
            }

            var firstBook = books.First();
            //or with predicate
            firstBook = books.First(b => b.Price > 10);
            //similary this method will throw an exeption if not found
            firstBook = books.FirstOrDefault();
            var paginatedBooks = books.Skip(2).Take(1);

            var booksCount = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(book => book.Price);
            var sumOfPrices = books.Sum(b => b.Price);

        }
    }
}
