using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSkill.Usage.TimerSample
{
    internal class ThreadTimer
    {
        private Timer timer;

        private event TimerCallback TimerCallBackHandler;

        public ThreadTimer()
        {
            TimerCallBackHandler = OntimerCallBack;
            //duetime how long will run first time
            // period interval in next time run.
            timer = new Timer(OntimerCallBack, "a", 0, 5000);
            Console.WriteLine(DateTime.Now.ToString());
        }

        public void InitMulTimesTimer()
        {
            // dispost it before new another one. or it will continue running
            StopTimer();
            //if no dispose, a continue
            timer = new Timer(OntimerCallBack, "b", 0, 5000);
        }

        public void StopTimer()
        {
            timer.Dispose();
        }

        public void OntimerCallBack(object state)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "" + state.ToString() + "," + DateTime.Now.ToString());
        }
    }
}