using System.Collections.Generic;

namespace interfaces
{
    partial class Program
    {
        public class VideoEncoder
        {
            private readonly IList<INotificationChannel> _notificationChannels;
            public VideoEncoder()
            {
                _notificationChannels = new List<INotificationChannel>();
            }
            public void Encode(Video video)
            {

                foreach(var channel in _notificationChannels)
                {
                    channel.Send(new Message());
                }

            }

            public void RegisterNotificationChannel(INotificationChannel channel)
            {
                _notificationChannels.Add(channel);

            }
        }
    }
}
