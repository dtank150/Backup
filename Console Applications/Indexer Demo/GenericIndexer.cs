using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Demo
{
    class GenericIndexer<T>
    {
        T[] _data;
        public GenericIndexer()
        {
            _data = new T[5];
        }
        public GenericIndexer(int size)
        {
            _data = new T[size];
        }
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }
        public int Length
        {
            get { return _data.Length; }
        }
    }
}
