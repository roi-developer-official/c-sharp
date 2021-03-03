using System.Collections.Generic;

namespace Lambda
{
    partial class Program
    {
        public class BookRepository
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book() { Title = "T1", Price = 2},
                    new Book() { Title = "T2", Price = 4},
                    new Book() { Title = "T3", Price = 10}

                };
            }
        }
    }
}
