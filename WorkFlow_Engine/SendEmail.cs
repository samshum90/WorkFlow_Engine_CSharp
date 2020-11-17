using System;

namespace WorkFlow_Engine
{
    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email...");
        }
    }
}
