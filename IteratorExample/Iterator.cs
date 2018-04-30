namespace IteratorExample
{
    public class Iterator: IIterator
    {
        private readonly Aggregator _aggregate;
        private int _current = 0;

        public Iterator(Aggregator aggregate)
        {
            _aggregate = aggregate;
        }

        public object First()
        {
            return _aggregate[0];
        }

        public object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}