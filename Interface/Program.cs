using System;

namespace Interface
{


    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Sql());
            customerManager.Add();


            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        private IInterface _Interface;

        public CustomerManager(IInterface Interface)
        {
            _Interface = Interface;
        }

        public void Add()
        {
            Console.WriteLine("Eklendi");
            _Interface.Log();
        }
    }


    interface IInterface
    {
        void Log();
    }
    class Sql : IInterface
    {
        public void Log()
        {
            Console.WriteLine("Sql veri tabanına LOGLANDI.! ");
        }
    }

    class Oracla : IInterface
    {
        public void Log()
        {
            Console.WriteLine("Oracle veri tabanına LOGLANDI.! ");
        }
    }

    class MySql : IInterface
    {
        public void Log()
        {
            Console.WriteLine("MySql veri tabanına LOGLANDI.! ");
        }
    }


}
