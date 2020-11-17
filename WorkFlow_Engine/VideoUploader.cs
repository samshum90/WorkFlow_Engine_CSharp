using System;

namespace WorkFlow_Engine
{
    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }    
}
