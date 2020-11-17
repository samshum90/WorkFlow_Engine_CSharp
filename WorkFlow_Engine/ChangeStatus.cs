using System;

namespace WorkFlow_Engine
{
    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status Changed...");
        }
    }
}
