using System;

namespace AdvancedRef.Events
{
    class NotifyStudentsService
    {
        public void OnCenterClosed(object sender, CenterEventArgs args)
        {
            Console.WriteLine("Notifying students");
        }
    }
}
