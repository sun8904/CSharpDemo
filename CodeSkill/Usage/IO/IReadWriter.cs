using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage.IO
{
    internal interface IReadWriter
    {
        void Save();

        void Load();
    }

    public class ReadWriterTest
    {
        private static void test()
        {
            IReadWriter readWriteTxt = new ReadWriteTxt();
            readWriteTxt.Load();
            readWriteTxt.Save();
            Console.Read();

            readWriteTxt = new ReadWriteXml();
            readWriteTxt.Load();
            readWriteTxt.Save();
            Console.Read();
        }
    }
}