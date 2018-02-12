using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSkill.Usage
{
    public class ThreadRelated
    {
        public static float Money = 0;

        public void Init()
        {
            Thread thread1 = new Thread(newthread);
            Thread thread2 = new Thread(new ThreadStart(threadMethod));
        }

        private void newthread(object obj)
        {
            throw new NotImplementedException();
        }

        public void threadMethod()
        {
        }

        public void countMoney()
        {
            ThreadPool.SetMaxThreads(4, 8);
            for (int i = 0; i < 60; i++)
            {
                ThreadPool.QueueUserWorkItem(run, 5000);
            }
            Thread.Sleep(3000);
            Console.WriteLine("all money is " + Money);
        }

        private void run(object state)
        {
            Money += int.Parse(state.ToString());
            //if (Money > 285)
            //  Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} ");
        }
    }
}