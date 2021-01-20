using System;
using System.Linq;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            var result = Add(ref  number1, number2); 
            Console.WriteLine(result);
            Console.WriteLine(number1);
        }

        static int Add( ref  int number1, int number2)
        {
            number1 = 30;

            return number1 + number2;
        }
    }
}
