using Homework.Interfaces;

namespace Homework.Readers;

public class ConsoleReader : IReader
{
    public string Read() => Console.ReadLine() ?? string.Empty;
}
