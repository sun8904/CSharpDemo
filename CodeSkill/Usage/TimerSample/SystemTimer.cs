using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CodeSkill.Usage.TimerSample
{
    using Thread = System.Threading.Thread;

    public class SystemTimer
    {
        public Timer FilterTimer;
        public Timer timer;
        public int Count;

        public SystemTimer()
        {
            FilterTimer = new Timer();
            FilterTimer.Interval = 1000 * 5;
            FilterTimer.Elapsed += FilterRefresh;
        }

        public void EnableTimer()
        {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Elapsed += timertask1;
            timer.Enabled = true;// same with start();
        }

        public void InitMulTimesTimer()
        {
            // two timer running
            timer = new Timer();
            timer.Interval = 2000;
            timer.Elapsed += timertask1;
            timer.Start();

            timer = new Timer();
            timer.Interval = 2000;
            timer.Elapsed += timertask2;
            timer.Start();
        }

        public void StopFirstTime()
        {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Elapsed += Stoptimertask;
            timer.Start();// start timer
        }

        public void AutoSetValue(bool set)
        {
            //defalut is true;
            // when auto set is false, duplicate set is invalid. only run one time Elapsed event.
            timer = new Timer();
            timer.Interval = 2000;
            timer.Elapsed += timertask;
            timer.AutoReset = set;
            timer.Start();// start timer
            Console.WriteLine($"{timer.Enabled}");
            Thread.Sleep(1000);
            Console.WriteLine($"{timer.Enabled}");
            Thread.Sleep(1000);
            Console.WriteLine($"{timer.Enabled}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"{timer.Enabled}");
            timer.Enabled = true;
            Console.WriteLine($"{timer.Enabled}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"{timer.Enabled}");
            timer.Start();
            Console.WriteLine($"{timer.Enabled}");
            Console.WriteLine("AutoSetValue done");
        }

        private void timertask1(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId + " timertask1 " + DateTime.Now.ToString());
            System.Threading.Thread.Sleep(1000);
        }

        private void timertask2(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId + " timertask2 " + DateTime.Now.ToString());
            System.Threading.Thread.Sleep(1000);
        }

        private void Stoptimertask(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId + " Stoptimertask " + DateTime.Now.ToString());
        }

        private void timertask(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"task {((Timer)sender).Enabled}");
            Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId + " timertask " + DateTime.Now.ToString());
            Console.WriteLine($"task {((Timer)sender).Enabled}");
        }

        public void StartTimer()
        {
            FilterTimer.Start();
            Console.WriteLine($"{DateTime.Now} start");
        }

        public void StopTimer()
        {
            FilterTimer.Stop();
            Console.WriteLine($"{DateTime.Now} stop");
        }

        public void DisposeTimer()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void FilterRefresh(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now} FilterRefresh,{Count}");
        }
    }
}