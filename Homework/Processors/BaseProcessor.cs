using Homework.Interfaces;

namespace Homework.Processors;

public abstract class BaseProcessor : IProcessor
{
    public IReader Reader { get; protected set; } = null!;
    public IWriter Writer { get; protected set; } = null!;

    public virtual void Process()
    {
        var data = Reader.Read();
        Writer.Write(data);
    }
}
