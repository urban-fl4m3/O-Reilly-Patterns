using Chapter10_State;
using System;

namespace Chapter11_Proxy
{
    class GumballMonitor
    {
        private readonly GumballMachine _gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {_gumballMachine.GetLocation()}");
            Console.WriteLine($"Current inventory: {_gumballMachine.GetCount()} gumballs");
            Console.WriteLine($"Current state: {_gumballMachine.GetState()}");
        }
    }
}
