using System;

namespace IntermediateRefresher.Exercises.Workflows
{
    class UploadFile : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading File");
        }
    }
}
