using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage.Collection
{
    public class Collections
    {
        public Array array { get; set; }
        public ArrayList arrayList { get; set; }

        public void Array()
        {
            string[][] stringArray = new string[][] { new string[] { "1", "2", "3" }, new string[] { "a", "b", "c", "d" }, new string[] { "a", "b", "c", "d" } };
            // 当前维度的元素个数
            Console.WriteLine(stringArray.Length + "," + stringArray.LongLength);
            // Array 有好多静态方可以可以操作数组
            array = stringArray;
            Console.WriteLine("abstract array" + array.Length + "," + array.LongLength);
            // ArrayList 是object集合，拆装箱有性能损耗
            arrayList = new ArrayList(4);
        }

        public void GenericArray()
        {
            //双向链表
            LinkedList<string> linkedList = new LinkedList<string>();
            List<string> list = new List<string>(4);
            Console.WriteLine($"count:{list.Count}, capacity:{list.Capacity}");
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(2);
            //no exception, not add to set
            hashSet.Add(2);
            HashSet<string> hashSetString = new HashSet<string>();
            hashSetString.Add("a");
            // can add null
            hashSetString.Add(null);
        }

        public void Dictionary()
        {
            //非泛型的 IDictionary
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "123");
            hashtable.Add("12", "abc");
            try
            {
                //ArgumentNullException  nullExceipton 不能为空
                //hashtable.Add(null, null);
                //ArgumentException  不能重复
                hashtable.Add("12", "abc");
            }
            catch (ArgumentNullException nullexeption)
            {
                Console.WriteLine("null exception");
                // throw nullexeption;
            }
            catch (ArgumentException ae)
            {
            }

            SortedList sortedList = new SortedList();
            sortedList[1] = "test";
            //ArgumentNullException  nullExceipton 不能为空
            //sortedList.Add(null, "abc");

            Console.WriteLine(sortedList.Count);
        }

        public void GenericDictionary()
        {
            //struct single pair 包含一个Key、Value的键值对
            KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>("key", "test");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Dictionary<int, string> myDic = new Dictionary<int, string>();
            foreach (KeyValuePair<int, string> item in myDic)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "sun");
            sortedList[2] = "yong";
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
        }

        public void Queue()
        {
        }
    }
}