using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deletegates deletegates = new Deletegates();
            //deletegates.voidDelegate(2);

            WorkManage manager = new WorkManage("Fred");
            manager.Arrangeworker(2, WorkType.GoToMeetings);
            manager = new WorkManage("Amelia");
            manager.ArrangenewJob(new Job(3, WorkType.Golf));
            Console.Read();
        }
    }
}
