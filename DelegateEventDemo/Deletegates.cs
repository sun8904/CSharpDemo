using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventDemo
{
    public delegate void voidDelegate(int a);
    class Deletegates
    {
        private int count = 0;
        public voidDelegate voidDelegate;
        public voidDelegate voidDelegate1;
        public Deletegates()
        {
            voidDelegate = new voidDelegate(Count);
            voidDelegate1 = new voidDelegate(Count);
            voidDelegate += voidDelegate1;
        }

        public void run()
        { 
}

        public void Count(int i)
        {
            count += i;
            Console.WriteLine("count "+ count);
        }
    }
}
