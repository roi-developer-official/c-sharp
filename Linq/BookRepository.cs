using System.Collections.Generic;

namespace Linq
{
    partial class Program
    {
        public class BookRepository
        {
            public IEnumerable<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book(){Title = "ADO.Net Step by Step", Price = 4},
                    new Book(){Title = "ASP.Net MVC", Price = 9.99f},
                    new Book(){Title = "ASP.Net Web Api", Price = 12},
                    new Book(){Title = "C# Advanced Topice", Price = 6}
                };
                
            }
        }
    }
}
