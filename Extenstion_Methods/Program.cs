using System;
using System.Collections.Generic;
using System.Linq;

namespace Extenstion_Methods
{
    partial class Program
    {
        //Extenstion method - allow us to add method to an exsiting class
        //without its source code been changed or creating a new class that inherits from it.
        //Note: if microsoft will add the same signeture method the instancce method will get priority
        static void Main(string[] args)
        {
            string post = "This is a very very long realy long string";
            var shortenPost = post.Shorten(5);
            Console.WriteLine(shortenPost);

            IEnumerable<int> numbers = new List<int>() { 1, 4, 6, 2 };
            Console.WriteLine(numbers.Max());
        }

    }
}
