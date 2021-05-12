namespace Chapter6_Command
{
    public interface IFan
    {
        void High();
        void Medium();
        void Low();
        void Off();
        int GetSpeed();
    }

    public class CeilingFan : IFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private string _location;
        private int _speed;

        public CeilingFan(string location)
        {
            _location = location;
            _speed = OFF;
        }

        public void High()
        {
            _speed = HIGH;
        }

        public void Medium()
        {
            _speed = MEDIUM;
        }

        public void Low()
        {
            _speed = LOW;
        }

        public void Off()
        {
            _speed = OFF;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
