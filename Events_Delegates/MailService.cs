using System;

namespace Events_Delegates
{
    partial class Program
    {
        public class MailService
        {
            public void OnVideoEncoded(object source, VideoEventArgs args)
            {
                Console.WriteLine("in MailService Sending an Email"+ args.Video.Title);

            }
        }

    }
}
