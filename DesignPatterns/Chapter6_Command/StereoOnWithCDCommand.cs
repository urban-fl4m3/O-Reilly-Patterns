namespace Chapter6_Command
{
    class StereoOnWithCDCommand : ICommand
    {
        private readonly IStereo _stereo;

        public StereoOnWithCDCommand(IStereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
            _stereo.DispatchCD();
            _stereo.SetVolume(-1);
        }
    }
}
