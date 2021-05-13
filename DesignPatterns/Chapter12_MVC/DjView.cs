using System;

namespace Chapter12_MVC
{
    public class DjView : IBeatObserver, IBpmObserver
    {
        private readonly IController _controller;
        private readonly IBeatModel _model;
        private readonly Random _rnd;

        public DjView(IController controller, IBeatModel model)
        {
            _controller = controller;
            _model = model;
            _model.RegisterObserver((IBeatObserver)this);
            _model.RegisterObserver((IBpmObserver)this);
            _rnd = new Random();
        }

        public void CreateView()
        {
            Console.WriteLine("Creating view...");
        }

        public void CreateControls()
        {
            Console.WriteLine("Creating controls...");
        }

        public void UpdateBPM()
        {
            var bpm = _model.GetBPM();
            if (bpm == 0)
            {
                Console.WriteLine("Offline");
            }
            else
            {
                Console.WriteLine($"Current BPM: {_model.GetBPM()}");
            }
        }

        public void UpdateBeat()
        {
            Console.WriteLine("Updating beat! 100!!");
        }

        public void EnableStopMenuItem()
        {
            Console.WriteLine("Enabling stop item");
        }

        public void DisableStopMenuItem()
        {
            Console.WriteLine("Disabling stop item");
        }

        public void EnableStartMenuItem()
        {
            Console.WriteLine("Enabling start item");
        }

        public void DisableStartMenuItem()
        {
            Console.WriteLine("Disabling start item");
        }

        public void ActionPerformed(string action)
        {
            switch (action)
            {
                case "setBPM":
                    {
                        int bpm = _rnd.Next(80, 140);
                        _controller.SetBPM(bpm);
                        break;
                    }

                case "increaseBPM":
                    {
                        _controller.IncreaseBPM();
                        break;
                    }

                case "decreaseBPM":
                    {
                        _controller.DecreaseBPM();
                        break;
                    }
            }
        }

        void IBpmObserver.Notify()
        {
            UpdateBPM();
        }

        void IBeatObserver.Notify()
        {
            UpdateBeat();
        }
    }
}
