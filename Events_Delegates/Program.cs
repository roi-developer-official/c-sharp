namespace Events_Delegates
{
    partial class Program
    {
        //Event - a mechanizem to comunicate between objects.
        // used in sligtly coupled application.
        // halpes with extending the application.
        //Delegate - an agreemaent / Contracct between a publicher and subscriber.
        // determines the signeture of the event handler method in subscriber.
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
           
        }
    }
}
