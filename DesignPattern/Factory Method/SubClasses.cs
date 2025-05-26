namespace InterviewPrep.DesignPattern.AbstractFactory;

internal class PDFPrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Printing PDF: {message}");
    }
}

internal class WordPrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Printing Word Document: {message}");
    }
}
