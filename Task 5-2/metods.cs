partial class Program
{
    /// <summary>
    /// Метод для запроса любимого цвета и перекраски фона в него
    /// </summary>
    static string ShowColor(string userName, int userAge)
    {
        Console.WriteLine("{0} {1} лет,\n напишите свой любимый цвет на английском с маленькой буквы", userName, userAge);
        var color = Console.ReadLine();
        DefoultColor();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                DefoultColor();
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                DefoultColor();
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                DefoultColor();
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                DefoultColor();
                break;
        }
        return color;
    }

    static void DefoultColor()
    {
         Console.BackgroundColor = ConsoleColor.Black;
         Console.ForegroundColor = ConsoleColor.Gray;
    }

    //static int[] GetArrayFromConsole()
    //{
    //    var result = new int[5];
    //    int temp = 0;

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }

    //    for (int i = 0; i < 5; i++)
    //    {
    //        for (int j = i + 1; j < result.Length; j++) 
    //        {
    //            if (result[i] > result[j]) 
    //            {
    //                temp = result[j];
    //                result[j] = result[i];
    //                result[i] = temp;
    //            }
    //        }
    //    }

    //    for (int i = 0; i < result.Length; i++) 
    //    {
    //        Console.Write(result[i]);
    //    } 
    //return result;
    //}

    static int[] GetArrayFromConsole() 
    {
        Console.Write("Введите количестов элементов в массиве простых чисел: ");
        int numberInArray = int.Parse(Console.ReadLine());

        var array = new int[numberInArray];
        int number = 0;

        for (int i = 0; i < numberInArray; i++)
        {
            number = i + 1;
            Console.Write("Введите " + number + "число в массиве: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    static int[] SortArray(int[] array) 
    {
        int temp = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        return array;
    }

    static void PrintArray(int[] array) 
    {
        foreach (int i in array) 
        {
            Console.Write(i + " ");
        }
    }
}



