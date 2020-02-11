using System;

namespace AdvancedRef.Events
{
    class CleanCenterService
    {
        public void CleanCenter(object sender, CenterEventArgs args)
        {
            Console.WriteLine("Started Cleaning Center..");
        }

    }
}
