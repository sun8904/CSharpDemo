using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateEventDemo
{
    public class WorkManage
    {
        Worker worker;
        public WorkManage(string workername)
        {
            worker = new Worker(workername)
            {
                Name = workername,
                //worker.workPerformed = new WorkPerformed(workPerformedHandle);
                workPerformed = workPerformedHandle
            };
            //worker.workCompleted = new EventHandler(Worker_workCompleted); // compile error
            // worker.workCompleted += new EventHandler(Worker_workCompleted);
            worker.workCompleted += Worker_workCompleted;
            worker.JobCompleted += Worker_JobCompleted;
            worker.JobCompleted += delegate (object sender, Job job) 
            {
                Console.WriteLine($"anonymous method {((Worker)sender).Name} Job complete. {job}");
            };

            worker.workCompleted += (s, e) =>
            {
                Console.WriteLine($"Lambda way Worked: { ((Worker)s).Name} work completed");
            };
        }

        private void Worker_JobCompleted(object sender, Job e)
        {
            Console.WriteLine($"{((Worker)sender).Name} Job complete. {e}");
        }

        internal void ArrangenewJob(Job job)
        {
            worker.DoJob(job);
        }

        private void Worker_workCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Worker)sender).Name} work completed");
        }

        public void Arrangeworker(int hours, WorkType workType)
        {        
            worker.DoWork(hours, workType);       
        }

        public void workPerformedHandle(int hours, WorkType workType)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"hours {hours}, worktype {workType}");
        }
    }
}
