using System;

namespace IntermediateRefresher.Exercises.Workflows
{
    class NotifyFileUploadFinished : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Notifying user");
        }
    }
}
