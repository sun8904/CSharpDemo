using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSkill.Usage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CodeSkill.Usage.Tests
{
    [TestClass()]
    public class IndexerClassTests
    {
        IntIndexerClass Indexer;
        private StringIndexerClass2 stringindexer;
       
        [TestInitialize]
        public void init()
        {
            Indexer = new IntIndexerClass();
            stringindexer = new StringIndexerClass2();
        }
        [TestMethod()]
        public void AddIntindexerTest()
        {
            //arrange
            Console.WriteLine(DateTime.Now.ToString("yyyyMMdd_HHmmss"));

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "123");
            hashtable.Add("12", "abc");
            // act
            Indexer[0] = "张三";
            Indexer[1] = "李四";
            //输出索引器的值，其实就是调用其get方法

            //assert
            Console.WriteLine(Indexer[0]);
            Console.WriteLine(Indexer[1]);

        }
        [TestMethod()]
        public void AddArrayindexerTest()
        {
            //arrange

            // act
            stringindexer[0] = "张三";
            stringindexer[1] = "李四";
            stringindexer[2] = "王四";
            //输出索引器的值，其实就是调用其get方法

            //assert
            Console.WriteLine(stringindexer[2]);
            Console.WriteLine(stringindexer["张三"]);
            Console.WriteLine(stringindexer["张"]);

        }
    }
}