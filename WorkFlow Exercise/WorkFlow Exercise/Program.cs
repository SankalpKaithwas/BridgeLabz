using System;
using System.Collections.Generic;

namespace WorkFlow_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUpload());
            workflow.Add(new ChangeStatus());
            workflow.Add(new CallWebService());
            workflow.Add(new SendEmail());

            var engine = new WorKFlowEngine();
            engine.Run(workflow);
        }

        public interface ITask
        {
            void Execute();
        }
        public interface IWorkFlow
        {
            void Add(ITask task);
            void Remove(ITask task);
            IEnumerable<ITask> GetTask();
        }

        public class Workflow : IWorkFlow
        {
            private readonly List<ITask> _task = new List<ITask>();
            
            public void Add(ITask task)
            {
                _task.Add(task);
            }

            public void Remove(ITask task)
            {
                _task.Remove(task);
            }

            public IEnumerable<ITask> GetTask()
            {                
                return _task;
            }

        }

        public class VideoUpload:ITask
        {
            public void Execute()
            {
                Console.WriteLine("Video is Uploading");
            }
        }
        public class CallWebService : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Calling Web Services");
            }
        }
        public class SendEmail : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Mail Sent");
            }
        }
        public class ChangeStatus : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Changing status");
            }
        }

        public class WorkFlowEngine
        {
            public void Run(IWorkFlow workflow)
            {
                foreach(ITask I in workflow.GetTask())
                {
                    try
                    {
                        I.Execute();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
            }




        }
       


    }
}
