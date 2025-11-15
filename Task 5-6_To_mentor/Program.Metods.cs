partial class Program
{
    public static void CheckDataAndSave(string StringToCheck, out int number)
    {
        if (int.TryParse(StringToCheck, out number)) ;
        else do
            {
                Console.WriteLine("Вы ввели не верное число. Попробуйте еще раз или наберите Стоп (Ввод данных о пользователе завершиться).");
                StringToCheck = Console.ReadLine();
                if (StringToCheck == "Стоп") break;
            }
            while (int.TryParse(StringToCheck, out number) == false);
        Console.WriteLine("Вы ввели корректное число.");
    }

    public static string[] GetArray(int number)
    {
        string[] array = new string[number];
        int count = 0;
        for (int i = 0; i < number; i++)
        {
            count = i + 1;
            Console.Write("Введите " + count + ": ");
            array[i] = Console.ReadLine();
        }
        return array;
    }
    public static void ShowUserData((string firstName, string lastName, int age, bool hasPet, int numberOfPet, string[] Pets, int numberOfFavourColors, string[] favourColors) user)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.Write("Имя и фамилия пользователя: {0} {1}. Его возраст: {2}.", user.firstName, user.lastName, user.age);
        Console.Write(" Наличие питомцев: {0}", user.hasPet);
        Console.WriteLine();
        
        if (user.hasPet == true)
        {
            foreach (string pet in user.Pets) 
                {
                    Console.WriteLine("    Имя питомца: " + pet);
                }
        }

        Console.WriteLine("Количество любимых цветов: {0}", user.numberOfFavourColors);

        foreach (string color in user.favourColors)
        {
            Console.WriteLine("    любимый цвет: " + color);
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}
