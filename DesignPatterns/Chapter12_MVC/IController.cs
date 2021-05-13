namespace Chapter12_MVC
{
    public interface IController
    {
        void Start();
        void Stop();
        void SetBPM(int bpm);
        void IncreaseBPM();
        void DecreaseBPM();

        DjView GetView();
    }
}
