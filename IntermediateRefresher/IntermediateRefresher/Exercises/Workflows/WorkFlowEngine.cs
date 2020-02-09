using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.Exercises.Workflows
{
    class WorkFlowEngine
    {
        private IList<IWorkFlow> _workFlows = new List<IWorkFlow>();

        public void Add(IWorkFlow workFlow)
        {
            _workFlows.Add(workFlow);
        }

        public void ExecuteAll()
        {
            Console.WriteLine($"Executing {_workFlows.Count} workflows");

            foreach (var workFlow in _workFlows)
            {
                workFlow.Execute();
            }
        }

        public static void Run()
        {

            var workflowEngine = new WorkFlowEngine();

            var uploader = new UploadFile();
            var notifier = new NotifyFileUploadFinished();

            workflowEngine.Add(uploader);
            workflowEngine.Add(notifier);

            workflowEngine.ExecuteAll();

        }
    }
}
