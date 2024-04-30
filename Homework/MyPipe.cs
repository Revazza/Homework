
using Homework.Enums;
using Homework.Interfaces;
using Homework.Processors;

public class MyPipe(IProcessor processor)
{
    private readonly IProcessor _processor = processor;

    public static MyPipe Create(ProcessorType processorType, string filePath)
    {
        return processorType switch
        {
            ProcessorType.ConsoleToFile => new MyPipe(new ConsoleProcessor(filePath)),
            ProcessorType.FileToConsole => new MyPipe(new FileProcessor(filePath)),
            _ => throw new NotImplementedException("Processor doesn't exist"),
        };
    }

    public void Execute()
    {
        _processor.Process();
    }

}