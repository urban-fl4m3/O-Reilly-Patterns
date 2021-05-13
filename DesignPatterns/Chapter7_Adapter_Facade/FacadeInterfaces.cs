namespace Chapter7_Adapter_Facade
{
    public interface IAmplifier
    {
        void On();
        void Off();
        void SetCd(ICdPlayer cd);
        void SetDvd(IDvdPlayer dvd);
        void SetStereoSound();
        void SetSurroundSound();
        void SetTuner();
        void SetVolume(int volume);
    }

    public interface IDvdPlayer
    {
        void On();
        void Off();
        void Eject();
        void Pause();
        void Play(string name);
        void SetSurroundAudio();
        void SetTwoChannelAudio();
        void Stop();
    }

    public interface IProjector
    {
        void On();
        void Off();
        void TvMode();
        void WideScreenMode();
    }

    public interface ICdPlayer
    {

        void On();
        void Off();
        void Eject();
        void Pause();
        void Play();
        void Stop();
    }

    public interface ITheaterLights
    {
        void On();
        void Off();
        void Dim(int level);
    }

    public interface IScreen
    {
        void Up();
        void Down();
    }

    public interface IPopcornPopper
    {
        void On();
        void Off();
        void Pop();
    }

    public interface ITunner
    {
        void On();
        void Off();
        void SetAm();
        void SetFm();
        void SetFrequency();
    }
}
