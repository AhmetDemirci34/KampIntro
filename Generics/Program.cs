using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> myClass = new MyClass<string>();
            myClass.Add("Ahmet");



            List<string> myclas2 = new List<string>();
            myclas2.Add("Ahmet");

            foreach (var item in myclas2)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }

    class MyClass<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyClass()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_tempArray.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;

        }

      

        public int count
        {
            get { return _array.Length; }
         

        }


    }
}
