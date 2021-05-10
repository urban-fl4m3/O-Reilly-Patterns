namespace Chapter2_Observer
{
    public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void Notify();
    }
}
