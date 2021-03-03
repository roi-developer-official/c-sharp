using System;

namespace Exeption__Handaling
{
    public class YouTubeExeption : Exception
    {
        public YouTubeExeption(string message, Exception innerExeption)
            :base(message, innerExeption)
        {

        }
    }
}
