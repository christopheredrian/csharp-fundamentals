using System.Collections.Generic;
using System.Text;

namespace AdvancedRef.Events
{
    class EventRunner
    {
        public static void Run()
        {   
            var video = new Video { Title = "Lord of the Rings" };
            
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
