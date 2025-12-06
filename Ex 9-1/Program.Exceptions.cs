using System.Security.Cryptography;

partial class Program
{
    public class MyOverflowException : OverflowException
    {
        public MyOverflowException(string massage = "Мое исключение: переполнение.")
            : base(massage)

        {
            HelpLink = "ya.ru";
            Data.Add("Дата создания исключения: ", DateTime.Now);
        }
    }
}
