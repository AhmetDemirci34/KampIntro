using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Ahmet<string> ahmet = new Ahmet<string>();
            ahmet.Ekle("Mehmet");
            ahmet.Ekle("Mehmet");
            ahmet.Ekle("Mehmet");
            ahmet.Ekle("Mehmet");


            Console.WriteLine(ahmet.Count);


            Console.ReadKey();
        }
    }

    class Ahmet<T>
    {
        T[] _array;
        T[] _arrayTemp;

        public Ahmet()
        {
            _array = new T[0];
        }

        public void Ekle(T item)
        {
            _arrayTemp = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _arrayTemp.Length; i++)
            {
                _array[i]= _arrayTemp[i];
            }

            _array[_array.Length - 1] = item;
        }

        

        public int Count
        {
            get { return _array.Length; }
          
        }

    }

    
}
