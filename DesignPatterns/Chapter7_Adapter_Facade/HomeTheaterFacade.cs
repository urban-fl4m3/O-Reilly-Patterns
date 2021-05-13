using System;

namespace Chapter7_Adapter_Facade
{
    public interface ITheaterFacade
    {
        void WatchMovie();
        void EndMovide();
    }

    public class HomeTheaterFacade : ITheaterFacade
    {
        public IAmplifier Amp { get; }
        public ITunner Tuner { get; }
        public IDvdPlayer Dvd { get; }
        public ICdPlayer Cd { get; }
        public IProjector Projector { get; }
        public ITheaterLights Lights { get; }
        public IScreen Screen { get; }
        public IPopcornPopper Popper { get; }

        public HomeTheaterFacade(IAmplifier amp,
            ITunner tuner,
            IDvdPlayer dvd,
            ICdPlayer cd,
            IProjector projector,
            ITheaterLights lights,
            IScreen screen,
            IPopcornPopper popper)
        {
            Amp = amp;
            Tuner = tuner;
            Dvd = dvd;
            Cd = cd;
            Projector = projector;
            Lights = lights;
            Screen = screen;
            Popper = popper;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie...");
            Popper.On();
            Popper.Pop();
            Lights.Dim(10);
            Screen.Down();
            Projector.On();
            Projector.WideScreenMode();
            Amp.On();
            Amp.SetDvd(Dvd);
            Amp.SetSurroundSound();
            Amp.SetVolume(5);
            Dvd.On();
            Dvd.Play("Movie");
        }

        public void EndMovide()
        {
            Console.WriteLine("Shutting movie theater down...");
            Popper.Off();
            Lights.On();
            Screen.Up();
            Projector.Off();
            Amp.Off();
            Dvd.Stop();
            Dvd.Eject();
            Dvd.Off();
        }
    }
}
