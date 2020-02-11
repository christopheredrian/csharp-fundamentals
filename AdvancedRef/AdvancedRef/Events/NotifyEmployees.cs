using System;

namespace AdvancedRef.Events
{
    class NotifyEmployees
    {
        public void OnCenterClosed(object sender, CenterEventArgs args)
        {
            Console.WriteLine("Notifying employees");
        }
    }
}
