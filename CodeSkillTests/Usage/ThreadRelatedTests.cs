using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSkill.Usage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CodeSkill.Usage.Tests
{
    [TestClass()]
    public class ThreadRelatedTests
    {
        [TestMethod()]
        public void countMoneyTest()
        {
            //arrage
            //act
            string test = "123";
            if(test!="123")
            {
                Console.WriteLine();
            }

            ThreadRelated threadRelated = new ThreadRelated();
            threadRelated.Init();
            threadRelated.countMoney();
            Thread.Sleep(1000);
            Console.WriteLine("all money is " + ThreadRelated.Money);
            Assert.AreEqual(ThreadRelated.Money, 300000);
           //assert
        }
    }
}