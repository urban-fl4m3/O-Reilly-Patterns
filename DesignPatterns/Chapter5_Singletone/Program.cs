using System;

namespace Chapter5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance().PrintHello();

            Console.ReadKey();
        }
    }
}
