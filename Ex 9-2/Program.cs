internal partial class Program
{
    private static void Main(string[] args)
    {
        ListOfPersons newList = new();
        UserChoice newChose = new();
        newChose.ChoiceNumber += newList.OnUserChoiceNumber;

        while (true)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Работа со списком пользователей:\n" +
                "0 - Формирование массива из пяти фамилий пользователей.\n" +
                "1 - сортировка введенного массива от А-Я\n" +
                "2 - обратная сортировка введенного массива от Я-А\n" +
                "3 - Вывести введенный список пользователей.\n" +
                "4 - Остановка работы программы.");
            Console.WriteLine("=================================");

            try
            {
                Console.Write("Введите число: ");
                newChose.Number = Convert.ToInt32(Console.ReadLine());

                switch (newChose.Number)
                {
                    case 0:
                        Cleanconsole();
                        break;

                    case 1:
                        Cleanconsole();
                        break;

                    case 2:
                        Cleanconsole();
                        break;

                    case 3:
                        Cleanconsole();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Вы ввели не верное число. Необходимо ввести либо 0, либо 1, либо 2, либо 3, либо 4.");
                        Cleanconsole();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Необходимо ввести либо 0, либо 1, либо 2, либо 3, либо 4");
                Cleanconsole();
            }
        }
    }
}