using System;

namespace Chapter10_State
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gunballMachine;

        public NoQuarterState(GumballMachine gunballMachine)
        {
            _gunballMachine = gunballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gunballMachine.SetState(_gunballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }
    }
}
