using System;

namespace Chapter6_Command
{
    public interface ILight
    {
        void On();
        void Off();
    }

    public class Light : ILight
    {
        public void Off()
        {
            Console.WriteLine("Lights off");
        }

        public void On()
        {
            Console.WriteLine("Lights on");
        }
    }
}
