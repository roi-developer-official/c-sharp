using System;
using System.Collections.Generic;

namespace Exeption__Handaling
{
    public class YouTubeApi
    { 
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Oops some low level youtube error");
            }
            catch (Exception ex)
            {

                throw new YouTubeExeption("Could not fetch the video from youtube", ex);
            }

            return new List<Video>();
        }
    }
}
