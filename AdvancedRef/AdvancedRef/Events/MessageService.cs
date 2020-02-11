using System;

namespace AdvancedRef.Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"Finished encoding {args.Video.Title}. Sending sms..");
        }
    }
}
