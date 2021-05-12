namespace Chapter6_Command
{
    public class CeilingFanMediumCommand : ICommand
    {
        private readonly IFan _fan;
        private int _prevSpeed;

        public CeilingFanMediumCommand(IFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _prevSpeed = _fan.GetSpeed();
            _fan.Medium();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.HIGH:
                    {
                        _fan.High();
                        break;
                    }
                case CeilingFan.MEDIUM:
                    {
                        _fan.Medium();
                        break;
                    }
                case CeilingFan.LOW:
                    {
                        _fan.Low();
                        break;
                    }
                case CeilingFan.OFF:
                    {
                        _fan.Off();
                        break;
                    }
            }
        }
    }
}
