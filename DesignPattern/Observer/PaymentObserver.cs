namespace InterviewPrep.DesignPattern.Observer;

internal class PaymentObserver : IObserver
{
    public void Publish(string message)
    {
        Console.WriteLine($"PaymentObserver received message: {message}");
    }
}