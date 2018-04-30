using System.Collections;

namespace IteratorExample
{
    public class Aggregator: IAggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}