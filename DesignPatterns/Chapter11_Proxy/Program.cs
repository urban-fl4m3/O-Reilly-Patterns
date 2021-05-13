using Chapter10_State;
using System;

namespace Chapter11_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            GumballMachine gumballMachine = new GumballMachine("Russia", 5);
            GumballMonitor monitor = new GumballMonitor(gumballMachine);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            monitor.Report();
            Console.ReadKey();
        }
    }
}
