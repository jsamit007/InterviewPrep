using InterviewPrep;
using InterviewPrep.DesignPattern.Abstract_Factory;
using InterviewPrep.DesignPattern.AbstractFactory;
using InterviewPrep.DesignPattern.Factory_Method;
using InterviewPrep.DesignPattern.Observer;

//Child p = new Child();
//Console.ReadKey();

//using var context = new AppDBContext();
//var employees = context.Employee;
//var message = "Second Highest Salary - " + employees.OrderByDescending(e => e.Salary).Skip(2).Take(1).FirstOrDefault(); // Row_Number() in SQL Server
//var query = context.Employee.OrderByDescending(e => e.Salary).GroupBy(e => e.Salary).Skip(2).Take(1);
//message = "Third Highest Salary - " + query;  // Row_Number() in SQL Server

////Console.WriteLine(query.ToQueryString());
//Console.WriteLine(message);

/*var printer = new PrinterService(new PDFPrinter());
printer.Print("Hello, World!");*/
//IDocumentFactory factory = new FTPStorageFactory();
/*var documentService = new DocumentService(factory);
documentService.Upload("file1", new byte[] { 1, 2, 3 });
documentService.Download("file1");
documentService.MultiPartUpload("file2", new List<byte[]> { new byte[] { 4, 5 }, new byte[] { 6, 7 } });*/

/**
 * Observer Pattern
*/
var observer = new PaymentObserver();
var subject = new OrderSubject();
subject.Attach(observer);
subject.Notify("Order placed successfully.");
Console.ReadKey();
