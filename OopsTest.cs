namespace InterviewPrep;

internal class Parent
{
    static Parent()
    {
        Thread.Sleep(100);
        Console.WriteLine("Parent static constructor");
    }

    public Parent()
    {
        Console.WriteLine("Parent constructor");
    }
}

internal class Child : Parent
{
    static Child()
    {
        Console.WriteLine("Child static constructor");
    }

    public Child()
    {
        Console.WriteLine("Child constructor");
    }
}
