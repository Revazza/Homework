using Homework.Readers;
using Homework.Writers;

namespace Homework.Processors;

public class FileProcessor : BaseProcessor
{

    public FileProcessor(string filePath)
    {
        Reader = new FileReader(filePath);
        Writer = new ConsoleWriter();
    }

    public override void Process()
    {
        base.Process();
        Console.WriteLine($"Data transferred from File to Console.");
    }
}
