using System;

namespace AdvancedRef.Events
{
    class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args) 
        {
            Console.WriteLine($"Video {args.Video.Title} finished encoding. Mail service sending an email");
        }
    }
}
