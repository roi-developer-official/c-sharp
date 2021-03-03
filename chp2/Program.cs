using System;
using System.Collections.Generic;
using System.Text;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a sentence with spaces");
            var input = Console.ReadLine();
            Console.WriteLine(convertToCamel(input));
            //Console.Write("Enter few numbers seperated by Comma!");
            //var input = Console.ReadLine();
            //while(input.Split(',').Length < 5)
            //{
            //    Console.Write("Invalid list");
            //    input = Console.ReadLine();
            //}

            //getSmalletsts(input);
            //Console.WriteLine(findMinNumber(input));
            //guessTheNumber();

        }

        static string convertToCamel(string input)
        {
            var builder = new StringBuilder();
            builder.Append(input.Substring(0, 1).ToUpper());
            if (!input.Contains(' '))
            { 
                builder.Append(input.Substring(1).ToLower());
                return builder.ToString();
            }
            else
            {
                for(var i = 1; i < input.Length; i++)
                {
                    if(input[i] != ' ')
                    {
                        builder.Append(input[i]);
                    }
                    else if(i + 1 < input.Length)
                    {
                        builder.Append(input.Substring(i + 1, 1).ToUpper());
                        i++;
                    }

                } 
            }
            return builder.ToString();
        }

        static void getSmalletsts(string input)
        {
            var list = new List<int>();
            foreach (var inp in input.Split(','))
            {
                list.Add(Convert.ToInt32(inp));
            }
            for (var i = 0; i < 3; i++)
            {
                var min = getSmallest(list);
                Console.WriteLine(min);
                list.Remove(min);
            }
             
        }
        static int getSmallest(List<int> list)
        {
            var min = list[0];
            foreach (var el in list)
            {
                if (el < min)
                {
                    min = el;
                }
            }
            return min;
        }




        static void guessTheNumber()
        {
            var random = new Random();
            Console.WriteLine("Guess The Number");
            for(var i = 0; i < 4; i++)
            {
                var number = random.Next(1, 10);
                var input = Console.ReadLine();
                if(Convert.ToInt32(input) == number)
                {
                    Console.WriteLine("Success");
                    break;
                }
                else
                {
                    Console.WriteLine("Not this time");
                }
            }
        }
        static int findMinNumber(string input)
        {
            var inputArray = input.Split(",");
            var list = new List<int>();
            foreach (var inp in inputArray)
            {
                list.Add(Convert.ToInt32(inp));
            }
            var max = 0;
            foreach (var number in list)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
