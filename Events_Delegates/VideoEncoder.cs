using System;
using System.Threading;
namespace Events_Delegates
{
    partial class Program
    {
        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }

        }
        public class VideoEncoder
        {
            //1 - Define a delegate
            //2 - Define an event
            //3 - Raise the event

            //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
            //public event VideoEncodedEventHandler VideoEncoded;

            // a newer way that is equivilent - so we dont have to create a delegate explicitly
            //if you dont want to pass any date
            //public event EventHandler VideoEncoded;
            //else 
            public event EventHandler<VideoEventArgs> VideoEncoded;

            public void Encode(Video video)
            {
                Console.WriteLine("Encoding Video...");
                OnVideoEncode(video);
                Thread.Sleep(3000);


            }

            protected virtual void OnVideoEncode(Video video)
            {
                if(VideoEncoded != null)
                {
                    VideoEncoded(this, new VideoEventArgs() { Video = video } );
                }

            }
        }

    }
}
