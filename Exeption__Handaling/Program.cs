using System;
using System.IO;

namespace Exeption__Handaling
{

    class Program
    {
        static void Main(string[] args)
        {
            //Exeption is a class
            var calculator = new Calculator();

            //you can have more than one catch block but be from the most specific to the less specific
            //you should always have a global expetion handling block:
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("user1");
                //calculator.Divide(1, 0); // DivideByZeroExeption
                //throw new Exception("Oops");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                //1- recover - prevent the application from crashing
                Console.WriteLine("Sorry unexpected error occured");
                Console.WriteLine(ex.InnerException);

                //or 2- rethrow the error
                //throw;
            }
            finally
            {
                //when you need to manualy cleanup
                //IDisposable:
                // Performs application-defined tasks associated with freeing, releasing, or resetting
                // unmanaged resources.
            }

            //this is a preffered way to handle this without dispose at the end
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                //throw;
            }


        }
    }
}
