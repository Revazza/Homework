using Homework.Interfaces;

namespace Homework.Writers;

public class FileWriter(string filePath) : IWriter
{
    private readonly string _filePath = filePath;
    public void Write(string data) => File.WriteAllText(_filePath, data);
}
