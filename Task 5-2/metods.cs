partial class Program
{
    /// <summary>
    /// Метод для запроса любимого цвета и перекраски фона в него
    /// </summary>
    static string ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];
        int temp = 0;
 
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < result.Length; j++) 
            {
                if (result[i] > result[j]) 
                {
                    temp = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }
            }
        }

        for (int i = 0; i < result.Length; i++) 
        {
            Console.Write(result[i]);
        } 
    return result;
    }
}



