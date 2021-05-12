namespace Chapter6_Command
{
    class StereoOffWithCDCommand : ICommand
    {
        private readonly IStereo _stereo;

        public StereoOffWithCDCommand(IStereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
            _stereo.DispatchCD();
            _stereo.SetVolume(-1);
        }

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }
}
