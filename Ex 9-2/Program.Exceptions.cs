partial class Program
{
        public class MyArgumentException : ArgumentException
        {
            public MyArgumentException(string massage = "Мое исключение: Пустые поля в фамилии пользователся не допускаются!.")
                :base(massage) 
            {
                HelpLink = "ya.ru";
                Data.Add("Дата создания исключения: ", DateTime.Now);
            }
        }
}
