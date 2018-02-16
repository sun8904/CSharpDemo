using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcrtionFunDemo
{
    public delegate int DelCount(int a, int b);
    public class ProccessData
    {
        public void ProcessDelegate(int a ,int b, DelCount count)
        {
            Console.WriteLine("Delegate "+count(a, b));
        }

        public void ProcessAction(int a, int b, Action<int,int> count)
        {
            count(a, b);
        }

        public void ProcessFun(int a, int b, Func<int,int,int> count)
        {
            Console.WriteLine("Fun " + count(a, b));
        }
    }
}
