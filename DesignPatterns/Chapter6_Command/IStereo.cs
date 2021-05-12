using System;

namespace Chapter6_Command
{
    public interface IStereo
    {
        void On();
        void Off();
        void SetCD();
        void DispatchCD();
        void SetVolume(int level);
    }

    public class Stereo : IStereo
    {
        public void DispatchCD()
        {
            Console.WriteLine("Dispatching CD");
        }

        public void Off()
        {
            Console.WriteLine("Turns stereo off!");
        }

        public void On()
        {
            Console.WriteLine("Turns stereo on!");
        }

        public void SetCD()
        {
            Console.WriteLine("Set up CD");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Volume now at {level} level");
        }
    }
}
