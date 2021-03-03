using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon;
namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Id = 1 }; // this is the right way instead of using multiple ctors
            customer.Orders.Add("fruit");
            Console.WriteLine(customer.Orders.Count);
            var res2 = customer.Add(new int[] { 1, 2, 5 });
            var res = customer.Add(2, 4, 6);
            var a = 1;
            // this is not a right way at all and are here for an example if you'll ancounter then in other ppl code
            customer.myMethod(ref a);
            //Console.WriteLine(a); // 3
            customer.myMethodB(out a);
            //Console.WriteLine(a); // 1
            // end 

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine("parse success" + number);
            }

            //private variables - accessible only from inside the class
            var person = new Person(new DateTime(2018, 2, 4));
            person.SetPhone("1234");
            Console.WriteLine(person.GetPhone());
            person.Name = "Bob";
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            //person.Birthdate = new DateTime(1998, 23, 2); //can't set this

            //protected - accessible only from the class and it's derived classes
            //internal -reffers to class - accessible only from the same assembly (class library)
            //protected internal - combined both
            var animal = new Animale(); // from the Amazon library
            var name = animal.GetName();


            //indexers
            var cookie = new HttpCookie();
            cookie["name"] = "Roei";
            Console.WriteLine(cookie["name"]);

            //UpCasting
            var text = new Text();
            Shape shape = text;
            // text and shape are both pointing to the same object in memory.
            //but shape has a more limited view.
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); // 100
            StreamReader reader = new StreamReader(new MemoryStream()); //have method to read/wtite to/from a file
            var list = new ArrayList();
            list.Add(1);
            list.Add("string");
            list.Add(new Text());
            // all will converted (Upcasted) to the Object class
            // a better way though is to use a generic list

            //DownCasting
            Shape shapeD = new Text(); // object of type shape with a limited view
            Text textD = (Text)shape; // now we have access to all properties.

            //if youre not sure about the runtime type of an object:
            textD = shape as Text;
            if(textD != null)
            {
                // do somthing
            }
            //or 
            if(shapeD is Text)
            {
                textD = (Text)shape;
            }

            //those boxing and unbozing have perfromence panelty
            //boxing - the process of converting a value type to an object refference
            int num = 10;
            Object obj = num;

            //unboxing - the reverse process.
            Object obj2 = 10;
            int num2 = (int)obj2;


        }
    }

    public class Customer
    {
        public int Id;
        private string _name;
        public readonly List<string> Orders;
        public readonly List<string> Orders2 = new List<string>();

        //public:
        //private is preffered encapsulation : hiding details from other classes
        public Customer()
        {
            this.Orders = new List<string>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;

        }

        public Customer(int id, string name)
            : this(id)
        {
            this._name = name;
        }

        public int Add(params int[] numbers)
        {
            var res = 0;
            foreach (var num in numbers)
            {
                res += num;
            }
            return res;
        }
        public void myMethod(ref int a)
        {
            a += 2;
        }

        public void myMethodB(out int result)
        {
            result = 1;
        }

        
    }

    public class Person
    {
 
        //private fields
        private string _phone;
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }
       // code snippet : prop + tab
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }

        public void SetPhone(string phone)
        {
            _phone = phone;
        }

        public string GetPhone()
        {
            return _phone;
        }
    }

    public class HttpCookie
    {
        //dictionary for fast access by key , a list for fast access by index
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get 
            {
                return _dictionary[key];
            }
            set 
            {
                _dictionary[key] = value;
            }
        }


    }


    public class Shape 
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

    }


}
