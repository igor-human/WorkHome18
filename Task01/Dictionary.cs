using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private List<TKey> _keys;
        private List<TValue> _values;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        // Метод добавления элемента
        public void Add(TKey key, TValue value)
        {
            if (_keys.Contains(key))
            {
                throw new ArgumentException("An element with the same key already exists.");
            }
            _keys.Add(key);
            _values.Add(value);
        }

        // Индексатор для получения значения элемента по ключу
        public TValue this[TKey key]
        {
            get
            {
                int index = _keys.IndexOf(key);
                if (index == -1)
                {
                    throw new KeyNotFoundException("The key was not found.");
                }
                return _values[index];
            }
        }

        // Свойство только для чтения для получения общего количества элементов
        public int Count
        {
            get { return _keys.Count; }
        }

        // Реализация метода GetEnumerator для поддержки foreach
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < _keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
            }
        }

        // Необобщенная реализация метода GetEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
