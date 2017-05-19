using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class Item
    {
        private string _name;

        public Item(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }

    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }

    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }

        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
