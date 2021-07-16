using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace sweeftDigital
{
    class MyStack : IEnumerable
    {
        public int Count { get; private set; }
        private string[] _array = Array.Empty<string>();

        public void Push(object obj)
        {
            Count += 1;
            Array.Resize(ref _array, Count);
            _array[Count - 1] = obj.ToString();
        }

        public object Pop()
        {
            Count -= 1;
            string lastelement = _array[Count];
            Array.Resize(ref _array, Count);

            return lastelement;
        }
        public object Peek()
        {
            string lastelement = _array[Count - 1];
            return lastelement;
        }
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_array);
        }
    }
}

