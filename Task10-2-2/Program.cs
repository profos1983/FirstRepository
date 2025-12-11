var writer = new Writer();
((IWriter)writer).Write();

IWriter writer2 = new Writer();
writer2.Write();

var worker = new Worker();
((IWorker)worker).Build();

public interface IWriter
{
    void Write();
}

public class Writer : IWriter
{
    void IWriter.Write()
    {

    }
}

public interface IWorker
{
    public void Build();
}

public class Worker : IWorker
{
    public void Build()
    {
        throw new NotImplementedException();
    }
}