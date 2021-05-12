using System;

namespace Chapter5_Singleton
{
    public class Singleton
    {
        private Singleton()
        {

        }

        public void PrintHello()
        {
            Console.WriteLine("Hello, world!");
        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
