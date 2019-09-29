using System;

namespace ds.algorithms.DataStructures
{
    public class CustomList<T>
    {
        private T[] _array;
        private int _size = 0;
        private int _maxCapacity = 0;

        public int Count => _size;

        public CustomList()
        {
            _array = new T[10];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                {
                    throw new IndexOutOfRangeException();    
                }

                return _array[index];
            }

            set
            {
                if (index < 0 || index >= _size)
                {
                    throw new IndexOutOfRangeException();
                }

                _array[index] = value;
            }
        }

        #region ListOperations

        public void Add(T value)
        {
            if (_size == _maxCapacity)
            {
                _maxCapacity = _maxCapacity == 0 ? 4 : _maxCapacity * 2;
                Array.Resize(ref _array, _maxCapacity);
            }

            _array[_size] = value;
            _size++;
        }

        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_array, 0, _size);
                _size = 0;
            }
        }

        public int IndexOf(T value)
        {
            return Array.IndexOf(_array, value, 0, _size);
        }

        public bool Remove(T value)
        {
            var index = IndexOf(value);

            if (index < 0) return false;

            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _size)
            {
                throw new IndexOutOfRangeException();
            }

            _size--;

            if (index < _size)
            {
                Array.Copy(_array, index + 1, _array, index, _size - index);
            }

            _array[_size] = default(T);
        }

        public override string ToString()
        {
            var output = string.Empty;

            for (int i = 0; i < _size - 1; i++)
            {
                output = output + _array[i] + ',';
            }

            return output + _array[_size - 1];
        }

        #endregion
    }
}
