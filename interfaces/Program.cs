using System;

namespace interfaces
{
    partial class Program
    {


        static void Main(string[] args)
        {
            //reason for using interfaecs:
            //Testability- when we unit testing a class we must isolate it (remove all dependancies to another classes)
            var orderProcessor = new OrderProcessor(new ShippingCalculator()); // this is a dependancy but in the main mthod so i'ts fine.
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

            //Extensibility - we create new classes insted of changing the code in one class
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            var dbMigratoB = new DbMigrator(new FileLogger(@"c:\logging\log.txt"));
            dbMigratoB.Migrate();


            //polymphism:
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());

        }
    }
}
