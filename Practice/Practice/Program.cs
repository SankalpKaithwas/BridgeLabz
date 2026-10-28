using System;
using System.IO;
using System.Collections.Generic;
namespace Practice
{
   
    class Program
    {
        


        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new Callwebservice());
            workflow.Add(new SendEmail());
            workflow.Add(new VideoUp());
            workflow.Add(new VideoStatus());

            var engine = new workflowengine();
            engine.Run(workflow);
        }
        public interface Itask
        {
            public void Execute();

        }
        public interface IWorkflow
        {
            public void Add(Itask task);
            public void Remove(Itask task);
            IEnumerable<Itask> GetTask();
        }

        public class Workflow : IWorkflow
        {
            readonly List<Itask> _task = new List<Itask>();

            public void Add(Itask task)
            {
                _task.Add(task);
            }

            public void Remove(Itask task)
            {
                _task.Remove(task);
            }
            public IEnumerable<Itask> GetTask()
            {
                return _task;
            }
        }

        public class VideoUp:Itask
        {
            public void Execute()
            {
                Console.WriteLine("Uploading");
            }
        }

        public class Callwebservice:Itask
        {
            public void Execute()
            {
                Console.WriteLine("Calling");
            }
        }
        public class SendEmail:Itask
        {
            public void Execute()
            {
                Console.WriteLine("Email sent");
            }
        }
        public class VideoStatus:Itask
        {
            public void Execute()
            {
                Console.WriteLine("Processing");
            }
        }

        public class workflowengine
        {
            public void Run(IWorkflow workflow)
            {
                foreach (Itask item in workflow.GetTask())  
                {
                    try
                    {
                        item.Execute();
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
