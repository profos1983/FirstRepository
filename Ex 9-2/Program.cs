ListOfPersons newList = new();

while (true)
{
    Console.WriteLine("=================================");
    Console.WriteLine("Введите следующие числа для:\n" +
        "1 - сортировка введенного массива от А-Я\n" +
        "2 - обратная сортировка введенного массива от Я-А\n" +
        "3 - Формирование массива из пяти фамилий пользователей.\n" +
        "4 - Вывести введенный список пользователей.\n" +
        "5 - Остановка работы программы.");
    try
    {
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                if (newList.ListIsNull() != true)
                {
                    newList.SortList();
                    newList.PrintList();
                    Console.WriteLine();
                    Cleanconsole();
                }
                else
                {
                    Console.WriteLine("Список пользователей не заполнен! Вначале сформируйте список пользователей.");
                    Cleanconsole();
                }
                break;

            case 2:
                if (newList.ListIsNull() != true)
                {
                    newList.ReverseSort();
                    newList.PrintList();
                    Console.WriteLine();
                    Cleanconsole();
                }
                else
                {
                    Console.WriteLine("Список пользователей не заполнен! Вначале сформируйте список пользователей.");
                    Cleanconsole();
                }
                break;

            case 3:
                newList.CreateList();
                newList.PrintList();
                Cleanconsole();
                break;
            
            case 4:
                if (newList.ListIsNull() != true)
                {
                    newList.PrintList();
                    Cleanconsole();
                }
                else
                {
                    Console.WriteLine("Список пользователей не заполнен! Вначале сформируйте список пользователей.");
                    Cleanconsole();
                }
                break;

            case 5:
                return;


            default:
                Console.WriteLine("Вы ввели не верное число. Необходимо ввести либо 1, либо 2, либо 3, либо 4.");
                Cleanconsole();
                break;
        }
    }
    catch (Exception ex) 
    { 
        Console.WriteLine("Необходимо ввести либо 1, либо 2, либо 3, либо 4."); 
    }
}
