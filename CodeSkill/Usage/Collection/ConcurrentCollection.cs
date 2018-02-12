using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage.Collection
{
    public class ConcurrentCollection
    {
        private ConcurrentDictionary<string, string> concurrentDictionary = new ConcurrentDictionary<string, string>();

        private ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
        private ConcurrentStack<string> concurrentStack = new ConcurrentStack<string>();
        private ConcurrentBag<string> concurrentBag = new ConcurrentBag<string>();
        private IProducerConsumerCollection<string> producerConsumerCollection;
        private BlockingCollection<string> blockingCollection = new BlockingCollection<string>();

        public void UseConcurrentDictionary()
        {
            //concurrentDictionary[null] = "test";
            concurrentDictionary["a"] = "test1";
            concurrentDictionary["a"] = "test";
            concurrentDictionary.TryAdd("a", "test2");
            concurrentDictionary.TryAdd("b", "test2");
            int f = (int)(concurrentDictionary["c"]?.Length);
        }

        public void UseQueue()
        {
            concurrentQueue.Enqueue("sun");
            concurrentQueue.Enqueue("yong");
            concurrentQueue.Enqueue("liang");
            string name;
            bool isEmpty = concurrentQueue.TryDequeue(out name);
            if (isEmpty)
            {
                Console.WriteLine($"name is {name}");
            }

            isEmpty = concurrentQueue.TryPeek(out name);
            if (isEmpty)
            {
                Console.WriteLine($"peek name is {name}");
            }
        }

        public void UseStack()
        {
            concurrentStack.Push("sun");
            concurrentStack.Push("yong");
            concurrentStack.Push("liang");
            string name;
            bool isEmpty = concurrentStack.TryPop(out name);
            if (isEmpty)
            {
                Console.WriteLine($"name is {name}");
            }

            isEmpty = concurrentStack.TryPeek(out name);
            if (isEmpty)
            {
                Console.WriteLine($"peek name is {name}");
            }
        }

        public void UseBag()
        {
            concurrentBag.Add("sun");
            concurrentBag.Add("yong");
            concurrentBag.Add("liang");

            string name;
            bool isEmpty = concurrentBag.TryTake(out name);
            if (isEmpty)
            {
                Console.WriteLine($"name is {name}");
            }
            isEmpty = concurrentBag.TryPeek(out name);
            if (isEmpty)
            {
                Console.WriteLine($"peek name is {name}");
            }
            UseIProducerComsumerCollection(concurrentBag);
        }

        public void UseIProducerComsumerCollection(IProducerConsumerCollection<string> producerConsumer)
        {
            producerConsumer.TryAdd("sun");
            producerConsumer.TryAdd("yong");
            producerConsumer.TryAdd("liang");

            string name;
            bool isEmpty = producerConsumer.TryTake(out name);
            if (isEmpty)
            {
                Console.WriteLine($"name is {name}");
            }
        }
    }
}