using System.Text;

namespace Chapter6_Command
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand fakeCommand = new FakeCommand();

            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = fakeCommand;
                _offCommands[i] = fakeCommand;
            }

            _undoCommand = fakeCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void PressOn(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void PressOff(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void PressUndo()
        {
            _undoCommand.Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----------Remote Control----------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {_onCommands[i].GetType().Name}    {_offCommands[i].GetType().Name}\n");
            }

            return sb.ToString();
        }
    }
}
