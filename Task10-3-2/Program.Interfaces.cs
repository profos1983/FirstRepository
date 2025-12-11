partial class Program
{
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {

        }

        public void SendEmail()
        {
        }

        public void Write() 
        {
        }


    }
}