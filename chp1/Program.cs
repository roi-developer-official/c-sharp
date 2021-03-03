using chapter1.Math;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace chapter1
{
    public enum ShippingMethod
    {
        Regular = 1,
        Registerd = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Notes: 
            //classes are refference type when structore are value type.

            //Types:
            var a = 'A';
            Console.WriteLine("{0} {1}", a, a.ToString());
            int[] numbers = new int[3];
            numbers[0] = 23; // { 23 , 0 , 0 }
            var numbers2 = new int[3] { 2, 3, 4 };
            string firstName = "yoy";
            string lastName = "wew";
            string name = firstName + " " + lastName;
            string name2 = string.Format("{0} {1}", lastName, firstName);
            string join = string.Join(",", numbers);
            //list[0] = "dfdf"; //wont work
            //string path = "c:\\pro\\folder1";
            //string path = @"c:\pro\folder1";

            //Arrays
            //rectangular
            var matrix = new int[3, 5];
            //jagged
            var array = new int[3][];
            array[0] = new int[2];
            var nums = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine(nums.Length);
            //methods
            var index = Array.IndexOf(nums, 9);
            Array.Clear(nums, index, 2); // set to zero / false / null
            Array.Copy(nums, numbers, 3);
            Array.Sort(nums);
            Array.Reverse(numbers);


            //Lists:
            var list = new List<int>() { 1, 2, 3, 4 };
            list.Add(1);
            list.AddRange(new int[3] { 2, 5, 7 });
            list.IndexOf(1);
            Console.WriteLine(list.Count);
            list.Remove(7); // remove the 7 
            list.Clear(); //remove all

            //Dates and Times
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Dates:");
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));
            //Time span - represente a length of time
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            TimeSpan.FromHours(1); // more readable
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(1);
            var duration = start - end;

            Console.WriteLine(timeSpan.Minutes); // 2
            Console.WriteLine(timeSpan.TotalMinutes); // 62.05
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));
            Console.WriteLine(TimeSpan.Parse("01:02:03"));

            //Texts
            var fullName = "me and you  ";
            Console.WriteLine("Trim: '{0}'", firstName.Trim()); //me and you
            Console.WriteLine("ToUpper '{0}'", fullName.ToUpper());
            var inx = fullName.IndexOf(' ');
            var firName = fullName.Substring(0, inx);
            var lasName = fullName.Substring(inx + 1);
            Console.WriteLine("first " + firName);

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]);
            fullName.Replace("you", "mary"); // the original string is not effected
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid"); // invalid
            }
            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");// invalid
            }
            var inp = "25";
            var inpNum = Convert.ToByte(inp);
            var price = 29.95f;
            var priceStr = price.ToString("C"); // currency (C0) for no dec point;

            //Summerizing Text
            var sentence = "this is a really really long text";
            const int maxLength = 20;
            if(sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalChars = 0;
                var summaryWords = new List<string>();
                foreach(var word in words)
                {
                    summaryWords.Add(word);
                    totalChars += word.Length + 1;
                    if(totalChars > maxLength)
                    {
                        break;
                    }
                }
                String.Join(" ", summaryWords + "...");
            }
            //StringBuilder - works on the original string
            var builder = new StringBuilder();
            builder.Append('-', 10).AppendLine().Append("Header");
            builder.Replace("-", "+");
            builder.Remove(2, 10);
            builder.Insert(0, new string('-', 5));
            Console.WriteLine(builder[0]); 

            //Enums
            var shippment = ShippingMethod.Express;
            Console.WriteLine((int)shippment); // 3
            Console.WriteLine(shippment); // Express
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //Express
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine((int)shippingMethod);

            //Classes 
            var john = new Person() { FirstName = "jon"};
            john.LastName = "doe";
            john.Interduce();
            var calculator = new Calculator();
            var result = calculator.Add(2, 4);

            //Random
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            var random = new Random();
            for(var i = 0; i < passwordLength; i++)
            {
                buffer[0] = (char)('a' + random.Next(0, 26));
            }
            var str = new string(buffer);


            //Files
            //every call the os make a security checking which can effect the performence
            var path = @"c:\ctempb\breadb.jpg";
            Console.WriteLine(Path.GetExtension(path)); // jpg
            Console.WriteLine(Path.GetFileName(path)); // breadb.jpg
            Console.WriteLine(Path.GetFileNameWithoutExtension(path)); // breadb
            Console.WriteLine(Path.GetDirectoryName(path)); // ctempb
            //File.Copy(path, @"c:\ctempb\breadb.jpg", true);
            //File.Delete(path);
            //if (File.Exists(path)) 
            //{
            //    var content = File.ReadAllText(path);
            //    Console.WriteLine("Faild to delete");
            //}
            //only in creating the FileInfo the os checks for authorization 
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"c:\ctemp\bread.jpg",true);
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
               Console.WriteLine("Faild to delete");
                var content = fileInfo.OpenRead();
            }

            //Directories
            //same security rule apply here too
            Directory.CreateDirectory(@"c:\ctemp\folder1");
            var files = Directory.GetFiles(path, ".jpg",SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {

                Console.WriteLine(directory);
            }
            if (Directory.Exists(path))
            {
                //
            }
            //Directory info
            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

           
        }
    }
}
