namespace Generics
{




    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            //System.Nullable
            var number = new Nullable<int>(5);
            System.Console.WriteLine("Has value ?" + number.HasValue);
            System.Console.WriteLine("value:" + number.GetValueOrDefault());
       
        }
    }
}
