using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage.Collection
{
    public class CollectionTest
    {
        public static void test()
        {
            ConcurrentCollection concurrentCollection = new ConcurrentCollection();
            concurrentCollection.UseConcurrentDictionary();

            Collections collections = new Collections();
            collections.Array();
            collections.GenericArray();
            collections.Dictionary();
        }
    }
}