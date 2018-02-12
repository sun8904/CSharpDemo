using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage
{
    internal class Keywords
    {
        //private const string S = new string(new char[] { 'c', 'b' }); // no new in const
        private const string SC = "ab";

        private const string St = "ab";
        private readonly string ReadString1;
        public readonly string ReadString2 = "defalut";
        private static readonly string constreadonly = "cr";

        public Keywords()
        {
            ReadString1 = "rs1";
            ReadString2 = "rs2";
            //constreadonly = "constreadonly"; //error, put to static constructor
        }

        static Keywords()
        {
            constreadonly = "constreadonly";
        }

        public void Method()
        {
            const string fixvalue = "123";
            Console.WriteLine(fixvalue);
        }

        public static void Test()
        {
            Console.WriteLine(Keywords.St);
            Console.WriteLine(Keywords.constreadonly);
            var keywords = new Keywords();
            Console.WriteLine($"{keywords.ReadString1},{keywords.ReadString2}");
            //keywords.ReadString2 = "update"; // can not update readonly
        }
    }
}