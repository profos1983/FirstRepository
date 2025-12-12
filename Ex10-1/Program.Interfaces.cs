partial class Program
{
    public interface ISum
    {
        double Sum();
    }

    public interface ILogger
    {
        void Evernt(string message);
        void Error(string message);
    }
}
