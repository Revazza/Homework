using Homework.Readers;
using Homework.Writers;

namespace Homework.Processors;

public class ConsoleProcessor : BaseProcessor
{
    public ConsoleProcessor(string filePath)
    {
        Reader = new ConsoleReader();
        Writer = new FileWriter(filePath);
    }

    public override void Process()
    {
        base.Process();
        Console.WriteLine($"Data transferred from Console to File.");
    }
}
