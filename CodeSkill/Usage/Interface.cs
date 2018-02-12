using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage
{
    interface ICollect
    {
        void Add();
        void Del();
    }

    interface ICollect2
    {
        void TryAdd();
        void TryDel();
    }

    class Concretecollection : ICollect, ICollect2
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Del()
        {
            throw new NotImplementedException();
        }

        void ICollect2.TryAdd()
        {
            throw new NotImplementedException();
        }

        void ICollect2.TryDel()
        {
            throw new NotImplementedException();
        }
    }

    class Interface
    {
        public void test()
        {
            Concretecollection concretecollection = new Concretecollection();
            //  concretecollection.TryAdd();
            ((ICollect2)concretecollection).TryAdd();
        }
    }
}
