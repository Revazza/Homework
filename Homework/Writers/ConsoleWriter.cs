using Homework.Interfaces;

namespace Homework.Writers;

public class ConsoleWriter : IWriter
{
    public void Write(string data) => Console.WriteLine(data);
}
