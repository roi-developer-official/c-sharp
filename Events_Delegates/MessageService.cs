using System;

namespace Events_Delegates
{
    partial class Program
    {
        public class MessageService
        {
            public void OnVideoEncoded(object source, VideoEventArgs args)
            {
                Console.WriteLine("We are in Message Service..." + args.Video.Title);
            }
        }
    }
}
