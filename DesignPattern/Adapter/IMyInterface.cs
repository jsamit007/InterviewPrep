namespace InterviewPrep.DesignPattern.Adapter;

internal interface IMyInterface
{
}

internal class MyImplimentation : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("MyMethod called");
    }
}

internal interface IClientInterface
{
    void ClientMethod();
}

internal class ClientImplimentation : IClientInterface
{
    private readonly IMyInterface _myInterface;

    public ClientImplimentation(IMyInterface myInterface)
    {
        _myInterface = myInterface;
    }

    public void ClientMethod()
    {
        if (_myInterface is MyImplimentation impl)
        {
            impl.MyMethod();
        }
        else
        {
            Console.WriteLine("MyMethod not available in this implementation");
        }
    }
}
