using System;
using System.Collections.Generic;

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

    public interface ITask
    {
        void Execute();
    }    
    
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class WorkFlow : IWorkFlow
    {

        private readonly List<ITask> _tasks;

        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }    
    
    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling a Web Service...");
        }
    }
    
    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email...");
        }
    }
    
    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status Changed...");
        }
    }

    public class WorkFlowEngine
    {
   
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask T in workFlow.GetTasks())
            {
                T.Execute();
            }
        }
    }
}
