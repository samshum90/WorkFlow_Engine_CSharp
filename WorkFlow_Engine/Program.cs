using System;

namespace WorkFlow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            WorkFlowEngine engine = new WorkFlowEngine();
            engine.Run( workFlow );

            Console.ReadLine();
        }
    }
}
