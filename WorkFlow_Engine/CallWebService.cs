using System;

namespace WorkFlow_Engine
{
    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling a Web Service...");
        }
    }
}
