using System;


namespace Chapter12_MVC
{
    public interface IBeatModel
    {
        void Initialize();
        void On();
        void Off();
        void SetBPM(int bpm);
        int GetBPM();
        void RegisterObserver(IBeatObserver o);
        void RemoveObserver(IBeatObserver o);
        void RegisterObserver(IBpmObserver o);
        void RemoveObserver(IBpmObserver o);
    }
}
