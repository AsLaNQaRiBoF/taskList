using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mylist<T>
        where T: class
    {
        public T[] _arr;
        private static int _count;

        public Mylist()
        {
            _arr = new T[0];
            _count = 0;
            _count++;
        }
        public T this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }
        public static int Count { get { return _count; } }

        public void Add(T value)
        {
            Array.Resize(ref _arr, _arr.Length+1);
            _arr[_arr.Length-1] = value;
        }
        public void Clear()
        {
            Array.Clear(_arr, 0, _arr.Length);
            _count = 0;
        }
        public bool Exist(T value)
        {
            for (int i = 0; i< _arr.Length; i++)
            {
                if (_arr[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove(T value)
        {
            T[] newarray = new T[0];

            foreach (var items in _arr)
            {
                if (!items.Equals(value))
                {
                    Array.Resize(ref newarray, newarray.Length + 1);
                    newarray[newarray.Length - 1] = items;
                }
            }

            _arr = newarray;
        }
    }
}



