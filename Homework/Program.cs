using Homework.Enums;

var mockTextFilePath = @"C:\Users\sandro_revazishvili\source\repos\Homework\Homework\MockData.txt";

Console.WriteLine("1. To which direction is it necessary to transfer data?");
Console.WriteLine("   1. From console to file");
Console.WriteLine("   2. From file to console");
var processorType = Enum.Parse<ProcessorType>(Console.ReadLine() ?? "0");

// Commented this code because I already have mock file path
//Console.Write("Enter file path: ");
//var filePath = Console.ReadLine() ?? string.Empty;

var myPipe = MyPipe.Create(processorType, mockTextFilePath);
myPipe.Execute();



