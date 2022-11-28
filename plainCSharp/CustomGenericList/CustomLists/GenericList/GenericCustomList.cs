using System.Collections;

namespace CustomGenericList.CustomLists.GenericList
{
    public class GenericCustomList<T> : IList<T>
    {

        private T[] _elements = new T[8];
        private int _count;

        public GenericCustomList()
        {
            _count = 0;
        }

        public T this[int index]
        {
            get
            {
                return _elements[index];
            }
            set
            {
                _elements[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        //skip
        public bool IsReadOnly => throw new NotImplementedException();


        public void Add(T item)
        {
            if (_count < _elements.Length)
            {
                _elements[_count] = item;
                _count++;
            }
            else
            {
                // increase lengths
            }
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(T item)
        {
            if(_elements == null || _elements.Length == 0 || item == null)
            {
                return false;
            }

            for (int i = 0; i < Count; i++)
            {
                if(_elements[i] == null)
                {
                    return false;
                }

                if (_elements[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        //skip
        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_elements[i], arrayIndex++);
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)_elements.GetEnumerator();
        }

        // TODO: fix enumarator
        public IEnumerator GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_elements[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if ((_count + 1 <= _elements.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _elements[i] = _elements[i - 1];
                }
                _elements[index] = item;
            }
        }

        public bool Remove(T item)
        {
            if (IndexOf(item) > -1)
            {
                RemoveAt(IndexOf(item));
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }
                _count--;
            }
        }

    }
}
