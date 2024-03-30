using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class ExtendedDictionary<Key, Value1, Value2>
    {
        private readonly List<ExtendedDictionaryElement<Key, Value1, Value2>> dict = new List<ExtendedDictionaryElement<Key, Value1, Value2>>();

        public void AddOrUpdate(Key key, Value1 val1, Value2 val2)
        {
            var existingElement = dict.FirstOrDefault(x => Equals(x.Key, key));
            if (existingElement != null)
            {
                existingElement.Value1 = val1;
                existingElement.Value2 = val2;
            }
            else
            {
                var newElement = new ExtendedDictionaryElement<Key, Value1, Value2>
                {
                    Key = key,
                    Value1 = val1,
                    Value2 = val2
                };
                dict.Add(newElement);
            }
        }

        public void Print()
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value1} - {item.Value2}");
            }
        }

        public void Remove(Key key)
        {
            var itemToRemove = dict.FindIndex(x => Equals(x.Key, key));
            if (itemToRemove != -1)
            {
                dict.RemoveAt(itemToRemove);
            }
        }

        public bool ContainsKey(Key key)
        {
            return dict.Exists(x => Equals(x.Key, key));
        }

        public bool ContainsValues(Value1 val1, Value2 val2)
        {
            return dict.Exists(x => Equals(x.Value1, val1) && Equals(x.Value2, val2));
        }

        public int Count()
        {
            return dict.Count;
        }

        public ExtendedDictionaryElement<Key, Value1, Value2> this[Key key]
        {
            get
            {
                return dict.Find(x => Equals(x.Key, key));
            }
        }

        public IEnumerator<ExtendedDictionaryElement<Key, Value1, Value2>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        public bool ExistKey(Key key)
        {
            return ContainsKey(key);
        }

        public bool ExistValues(Value1 val1, Value2 val2)
        {
            return ContainsValues(val1, val2);
        }

    }
    public class ExtendedDictionaryElement<KeyElement, Value1Element, Value2Element>
    {
        public KeyElement Key { get; set; }
        public Value1Element Value1 { get; set; }
        public Value2Element Value2 { get; set; }
    }

}