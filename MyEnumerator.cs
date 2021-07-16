using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace sweeftDigital
{
    class MyEnumerator : IEnumerator
    {
        private object[] _items;
        private int _index;

        public MyEnumerator(object[] items)
        {
            _items = items;
            _index = -1;
        }
        public object Current
        {
            get
            {
                return _items[_index];
            }
        }
        public bool MoveNext()
        {
            if (_index + 1 < _items.Length)
            {
                _index++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            _index = -1;
        }
    }
}

