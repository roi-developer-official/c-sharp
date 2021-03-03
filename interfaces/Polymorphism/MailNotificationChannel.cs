using System;

namespace interfaces
{
    partial class Program
    {
        public class MailNotificationChannel : INotificationChannel
        {
            public void Send(Message message)
            {
                Console.WriteLine("Sending Mail...");
            }
        }
    }
}
