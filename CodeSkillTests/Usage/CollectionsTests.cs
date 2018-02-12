using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSkill.Usage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Specialized;
using CodeSkill.Usage.Collection;

namespace CodeSkill.Usage.Tests
{
    [TestClass()]
    public class CollectionsTests
    {
        [TestMethod()]
        public void AddDataTest()
        {
            Collections collections = new Collections();
            //collections.AddData();
            // Assert.Fail();
        }

        [TestMethod()]
        public void SortListSample()
        {
            SortedList sortedList = new SortedList();
            sortedList[1] = "test";
            Console.WriteLine(sortedList.Count);
        }

        [TestMethod()]
        public void StackSample()
        {
            Stack sortedList = new Stack();
            // 异常:
            //   T:System.InvalidOperationException:
            //     System.Collections.Stack 为空。
            Console.WriteLine(sortedList.Peek());
            Console.WriteLine(sortedList.Pop());
            //sortedList[1] = "test";
            Console.WriteLine(sortedList.Count);
            Stack<int> test = new Stack<int>();
        }

        [TestMethod()]
        public void HashMapTest()
        {
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add(null);
            hashSet.Add("abc");
            hashSet.Add("a");
            hashSet.Add("abc");
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, hashSet);
            Console.WriteLine(stream.ToArray().ToString());
        }

        [TestMethod()]
        public void NameCollectionTest()
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("ab", "A");
            nameValueCollection.Add("cb", "B");
            nameValueCollection.Add("cb", "C");
            string value = nameValueCollection[0];
            string value1 = nameValueCollection["a"];
            string value2 = nameValueCollection["A"];
            Dictionary<string, string> keypairs = new Dictionary<string, string>();
            keypairs.Add("1", "a");
            keypairs.Add("2", "b");
            keypairs.Add("3", "c");
            var list = keypairs.Values;
            foreach (var item in list)
            {
            }
        }
    }
}