using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///ref https://www.cnblogs.com/ArmyShen/archive/2012/08/27/2659405.html
/// </summary>
namespace CodeSkill.Usage
{
    public class IntIndexerClass
    {
        string[] names = new string[2];
        private string nameList;

        public string this[int index]
        {
            get
            {
                if (index < 2)
                    return names[index];
                else
                    return null;
            }

            set
            {

                if (index < 2)
                    names[index]= value;

            }
        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Equals(name))
                        return i;
                }
                return -1;
            }
        }
    }
    public class StringIndexerClass
    {
        Hashtable name = new Hashtable();
        public string this[string index]
        {
            get
            {
                return name[index].ToString();

            }
            set { name.Add(index, value); }
        }
    }

    public class StringIndexerClass2
    {
        Hashtable namelist = new Hashtable();
        //namelist.Values;
        Dictionary<int, string> names = new Dictionary<int, string>();
        public string this[int index]
        {
            get
            {
                return names[index].ToString();

            }
            set { names.Add(index, value); }
        }
        public int this[string name]
        {
            get
            {
                foreach (var item in names.Keys)
                {
                    if(names[item].Equals(name))
                    {
                        return item;
                    }
                }
                return -1;
            }
        }
    }

    //入职信息类
    public class EntrantInfo
    {
        //姓名、编号、部门
        private string name;
        private int number;
        private string department;
        public EntrantInfo()
        {

        }
        public EntrantInfo(string name, int num, string department)
        {
            this.name = name;
            this.number = num;
            this.department = department;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Num
        {
            get { return number; }
            set { number = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }

    //声明一个类EntrantInfo的索引器
    public class IndexerForEntrantInfo
    {
        private ArrayList ArrLst;//用于存放EntrantInfo类
        public IndexerForEntrantInfo()
        {
            ArrLst = new ArrayList();
        }

        //声明一个索引器：以名字和编号查找存取部门信息
        public string this[string name, int num]
        {
            get
            {
                foreach (EntrantInfo en in ArrLst)
                {
                    if (en.Name == name && en.Num == num)
                    {
                        return en.Department;
                    }
                }
                return null;
            }
            set
            {
                //new关键字：C#规定，实例化一个类或者调用类的构造函数时，必须使用new关键
                ArrLst.Add(new EntrantInfo(name, num, value));
            }
        }

        //声明一个索引器：以编号查找名字和部门
        public ArrayList this[int num]
        {
            get
            {
                ArrayList temp = new ArrayList();
                foreach (EntrantInfo en in ArrLst)
                {
                    if (en.Num == num)
                    {
                        temp.Add(en);
                    }
                }
                return temp;
            }
        }

        //还可以声明多个版本的索引器...
    }


    public class IndexerClass
    {
        public void Addindexer()
        {
            //索引器的使用
            IntIndexerClass Indexer = new IntIndexerClass();
            //“=”号右边对索引器赋值，其实就是调用其set方法
            Indexer[0] = "张三";
            Indexer[1] = "李四";
            //输出索引器的值，其实就是调用其get方法
            Console.WriteLine(Indexer[0]);
            Console.WriteLine(Indexer[1]);
        }
        public void Getindexer()
        {
            //索引器的使用
            IntIndexerClass Indexer = new IntIndexerClass();
            //“=”号右边对索引器赋值，其实就是调用其set方法
            Indexer[0] = "张三";
            Indexer[1] = "李四";
            //输出索引器的值，其实就是调用其get方法
            Console.WriteLine(Indexer[0]);
            Console.WriteLine(Indexer[1]);
        }

        public void GetValue()
        {
            //索引器的使用
            IntIndexerClass Indexer = new IntIndexerClass();
            //“=”号右边对索引器赋值，其实就是调用其set方法
            Indexer[0] = "张三";
            Indexer[1] = "李四";
            //输出索引器的值，其实就是调用其get方法
            Console.WriteLine(Indexer[0]);
            Console.WriteLine(Indexer[1]);
        }

    }
}
