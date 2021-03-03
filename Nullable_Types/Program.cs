using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date = null;
            DateTime? date2 = null;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            Console.WriteLine(date.Value); // this will throw exeption

            DateTime? date3 = new DateTime(2014, 1, 1);
            DateTime date4 = date3.GetValueOrDefault();
            date4 = date2 ?? DateTime.Today; // if date2 is null

            //static proogramming languages: c# , java
            //resolution at complile time
            //dynamic languages: javascript.
            //resolution done in runtime.
            //reflaction:
            object obj = "meme";
            var methodInfo = obj.GetType().GetMethod("getHashCode");
            methodInfo.Invoke(null, null);

            dynamic exelObject = "meme2";
            exelObject.Optimize(); //not a real method
            dynamic name = "roei";
            name = 10; //this is fine with dynamic.

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; //c is dynamic (int)

            int i = 5;
            dynamic d = i; //d is dynamic(int)
            long l = d; // int can convert to long



        }
    }
}
