using System;
using System.Collections.Generic;

namespace Chapter12_MVC
{
    public class BeatModel : IBeatModel
    {
        private readonly List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        private readonly List<IBpmObserver> _bpmObservers = new List<IBpmObserver>();
        private int _bpm = 90;

        public void Initialize()
        {
            Console.WriteLine("Initializing...");
        }

        public void On()
        {
            Console.WriteLine("Turning Beats On");
            SetBPM(90);
        }

        public void Off()
        {
            Console.WriteLine("Turning Beats Off");
            SetBPM(0);
        }

        public void SetBPM(int bpm)
        {
            _bpm = bpm;
            NotifyBpmObservers();
        }

        public int GetBPM()
        {
            return _bpm;
        }

        public void RegisterObserver(IBeatObserver o)
        {
            _beatObservers.Add(o);
        }

        public void RegisterObserver(IBpmObserver o)
        {
            _bpmObservers.Add(o);
        }

        public void RemoveObserver(IBeatObserver o)
        {
            _beatObservers.Remove(o);
        }

        public void RemoveObserver(IBpmObserver o)
        {
            _bpmObservers.Remove(o);
        }

        private void NotifyBpmObservers()
        {
            foreach(var o in _bpmObservers)
            {
                o.Notify();
            }
        }
    }
}
