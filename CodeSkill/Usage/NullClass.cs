using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage
{
    internal class NullClass
    {
        public int? i;

        public NullClass()
        {
            i = null;
        }

        public void Init()
        {
            i = 5;
        }

        public override string ToString()
        {
            return this.GetType() + i.ToString();
        }

        public static void Test()
        {
            Nullable<int> j = null;
            j = 1;
            Console.WriteLine("Nullable<int> type is:" + j.GetType()); // System.Int32
            var customer = new NullClass();
            Console.WriteLine(customer);
            Console.WriteLine(Nullable.Compare(customer.i, new NullClass().i));
            customer.Init();
            Console.WriteLine(customer);
            string a = null;
            string b = "2";
            string c = "3";
            Console.WriteLine(a ?? null ?? b ?? null ?? c ?? null);
            Console.ReadKey();
        }
    }
}