using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventDemo
{
    public delegate void WorkPerformed(int hours, WorkType workType);
    public class Worker
    {
        public string Name;
        public WorkPerformed workPerformed;
        private string workername;

        public Worker(string workername)
        {
            this.workername = workername;
            workCompleted = new EventHandler(Worker_workCompleted);
        }

        public event EventHandler workCompleted;
        public event EventHandler<Job> JobCompleted;

        public virtual void OnworkPerformed(int hours, WorkType workType)
        {
            if(workPerformed!=null)
            {
                workPerformed(hours, workType);
            }
        }

        public virtual void OnworkCompleted(object sender,EventArgs eventArgs)
        {
            workCompleted?.Invoke(sender, eventArgs);
            var del = workCompleted as EventHandler;
            if(null != del)
            {
                del(this, eventArgs);
            }
        }

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i <= hours; i++)
            {
                OnworkPerformed( i, workType);
            }
            var args = new EventArgs();

            OnworkCompleted(this, new EventArgs());
        }

        public void DoJob(Job job)
        {
            for (int i = 0; i <= job.Hours; i++)
            {
                OnworkPerformed(i, job.WorkType);
            }
            OnJobCompleted(this,job);
        }

        protected virtual void OnJobCompleted(Worker worker, Job job)
        {
            JobCompleted?.Invoke(worker, job);
        }

        private void Worker_workCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Self{((Worker)sender).Name} work completed");
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
