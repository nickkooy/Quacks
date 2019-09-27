using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quacks
{
    public class Bag<T>
    {
        readonly IRandom random;
        List<T> items;
        int length;
        public Bag(IRandom random, IEnumerable<T> items)
        {
            this.random = random;
            Set(items);
        }
        public Bag(IRandom random)
        {
            this.random = random;
            items = new List<T>();
            length = 0;
        }

        public void Add(T value)
        {
            items.Add(value);
            ++length;
        }

        public T Pull()
        {
            if (length == 0) return default(T);

            int index = random.Next(length);
            T item = items[index];
            items.RemoveAt(index);
            --length;
            return item;
        }

        public void Set(IEnumerable<T> values)
        {
            items = values.ToList();
            length = items.Count;
        }
    }
}
