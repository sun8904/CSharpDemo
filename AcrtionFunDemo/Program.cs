using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcrtionFunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DelCount delcount = delegate (int a, int b) { return a + b; };
            Action<int, int> action = delegate(int a, int b) {Console.WriteLine("Action" + (a + b)); };
            Action<int, int> action2 = (a, b) => { Console.WriteLine("Action" +( a + b)); };
            Func<int, int, int> func = (a, b) => { return a + b; };
            Func<int, int, int> func2 = (a, b) => { return a * b; };
            var ProcessCustom = new ProccessData();
            SumAction(2,2);
            SumAction4(4, 4);
            SumAction3(2, 2);
            var sum5 = SumAction5();
            var sumaction = SumAction(2,2);
            sumaction(1, 1);
            ProcessCustom.ProcessAction(3,3 , sumaction);
            ProcessCustom.ProcessAction(3, 3, SumAction4(4,4));
            ProcessCustom.ProcessAction(3, 3, SumAction3);
            ProcessCustom.ProcessAction(3, 3, sum5);
            ProcessCustom.ProcessAction(3, 3, SumAction2(2, 2));
            ProcessCustom.ProcessDelegate(2, 2, delcount);
            ProcessCustom.ProcessAction(2, 2, action);
            ProcessCustom.ProcessAction(2, 2, action2);
            ProcessCustom.ProcessFun(2, 2, func);
            ProcessCustom.ProcessFun(2, 3, func2);
            Console.Read();

        }

       public static Action<int, int> SumAction(int a,int b)
        {
            return Sum;
        }
        public static Action<int, int> SumAction3 = (x, y) => { Console.WriteLine($"sum3 is {x + y}"); };
        public static Action<int, int> SumAction4(int a, int b)
        {
            Console.WriteLine($"sum4 init is {a + b}");
            Action<int, int> methd = (x, y) => { Console.WriteLine($"sum4 is {x + y}"); };
            return methd;
        }

        public static Action<int, int> SumAction5()
        {            
            Action<int, int> methd = (x, y) => { Console.WriteLine($"sum5 is {x + y}"); };
            return methd;
        }
        public static Action<int, int> SumAction2(int a, int b)
        {
            Action<int, int> methd = (x, y)=> { Console.WriteLine($"sum2 is {a + b}"); };
            return methd;
        }

        public static void Sum(int a, int b)
        {
            Console.WriteLine($"sum is {a+b}");
        }
    }
}
