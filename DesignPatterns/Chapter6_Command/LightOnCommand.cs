namespace Chapter6_Command
{
    public class LightOnCommand : ICommand
    {
        private readonly ILight _light;

        public LightOnCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
