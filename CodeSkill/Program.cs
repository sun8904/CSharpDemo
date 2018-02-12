using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CodeSkill.Usage;
using CodeSkill.Usage.IO;
using CodeSkill.Usage.Collection;
using CodeSkill.Usage.TimerSample;
using CodeSkill.Usage.TaskSample;

namespace CodeSkill
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //new Thread(go).Start();
            //new Thread(go).Start();
            //Console.ReadKey();
            //CollectionTest.test();

            TaskSample.Test();
            //TaskSample.AsyncTaskExceptions_CanBeCaughtByCatch();
            //TaskSample.AsyncTaskExceptions2_CanBeCaughtByCatch();
            Console.ReadKey();
        }

        public static void go()
        {
            Console.WriteLine("thread " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}