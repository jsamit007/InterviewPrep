namespace InterviewPrep.DesignPattern.Observer;

internal class OrderSubject : ISubject
{
    private readonly List<IObserver> _observers = new();
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        _observers.ForEach(observer => observer.Publish(message));
    }
}
