using System;
using System.Threading;

namespace AdvancedRef.Events
{
    class Center
    {
        public string Name { get; set; }

        // Event 
        public event EventHandler<CenterEventArgs> CenterClosed;

        public void CloseCenter()
        {
            Console.WriteLine("Center closing ...");
            Thread.Sleep(3000);

            // Call all the callback functions registered 
            CenterClosed?.Invoke(this, new CenterEventArgs { Center = this });
        }

        protected virtual void OnCenterClosed()
        {
            CenterClosed?.Invoke(this, new CenterEventArgs { Center = this });
        }

        public static void Run()
        {
            var ctr = new Center { Name = "Snlv" };

            var notifyStudentsService = new NotifyStudentsService();
            var notifyEmployeesService = new NotifyEmployees();
            var cleanCenterService = new CleanCenterService();

            ctr.CenterClosed += notifyStudentsService.OnCenterClosed;
            ctr.CenterClosed += notifyStudentsService.OnCenterClosed;
            ctr.CenterClosed += cleanCenterService.CleanCenter;

            ctr.CloseCenter();
        }

    }
}
