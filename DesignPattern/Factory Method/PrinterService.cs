namespace InterviewPrep.DesignPattern.AbstractFactory;

internal class PrinterService
{
    private readonly IPrinter _printer;

    public PrinterService(IPrinter printer)
    {
        _printer = printer;
    }

    public void Print(string message)
    {
        _printer.Print(message);
    }
}
