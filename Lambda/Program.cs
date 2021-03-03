using System;

namespace Lambda
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Func<int,int> square = number => number * number;
            Console.WriteLine(square(5));
            //() =>
            // x=>
            // (x,y,x)=>
            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));

            var books = new BookRepository().GetBooks();
            var cheapBooks =  books.FindAll(IsCheaperThan10Dollars);
            var cheapBooksLambda = books.FindAll(b => b.Price < 10);

        }

        // a predicate method
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
