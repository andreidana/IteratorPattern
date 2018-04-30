using System;

namespace IteratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Aggregator
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            var i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
    }
}
