namespace Chapter12_MVC
{
    public class BeatController : IController
    {
        private readonly IBeatModel _model;
        private readonly DjView _view;
        
        public BeatController(IBeatModel model)
        {
            _model = model;
            _view = new DjView(this, model);
            _view.CreateView();
            _view.CreateControls();
            _view.DisableStopMenuItem();
            _view.EnableStartMenuItem();
            _model.Initialize();
        }

        public void Start()
        {
            _model.On();
            _view.DisableStartMenuItem();
            _view.EnableStopMenuItem();
        }

        public void Stop()
        {
            _model.Off();
            _view.DisableStopMenuItem();
            _view.EnableStartMenuItem();
        }

        public void IncreaseBPM()
        {
            var bpm = _model.GetBPM();
            _model.SetBPM(bpm + 1);
        }

        public void DecreaseBPM()
        {
            var bpm = _model.GetBPM();
            _model.SetBPM(bpm - 1);
        }

        public void SetBPM(int bpm)
        {
            _model.SetBPM(bpm);
        }

        //Just for tests
        public DjView GetView()
        {
            return _view;
        }
    }
}
