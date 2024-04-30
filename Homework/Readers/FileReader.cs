using Homework.Interfaces;

namespace Homework.Readers;

public class FileReader(string filePath) : IReader
{
    private readonly string _filePath = filePath;

    public string Read() => File.ReadAllText(_filePath);
}
