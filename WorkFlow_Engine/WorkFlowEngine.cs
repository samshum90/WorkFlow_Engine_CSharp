namespace WorkFlow_Engine
{
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
