partial class Program
{
    public class SumCalculator : ISum
    {
        ILogger Logger { get; }

        public int X { get; set; }

        public double Y { get; set; }

        public SumCalculator(ILogger logger)
        {
            Logger = logger;
        }

        public void SetX()
        {
            Console.Write("Введите первое число для сложения: ");
            bool check = false;
            while (check == false)
            {
                try
                {
                    X = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.Message);
                    Console.Write("Попробуйте ввести первое число снова: ");
                }
            }
        }

        public void SetY()
        {
            Console.Write("Введите второе число для сложения: ");
            bool check = false;
            while (check == false)
            {
                try
                {
                    Y = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.Message);
                    Console.Write("Попробуйте ввести второе число снова: ");
                }
            }
        }
        public double Sum()
        {
            Logger.Evernt("Сложение двух чисел произошло.");
            return X + Y;

        }
    }
    /// <summary>
    /// Класс, для логирования событий при работе простейшего калькулятора.
    /// </summary>
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            SetErrorColor();
            Console.WriteLine(message);
            SetDefaultColor();
        }

        public void Evernt(string message)
        {
            SetEventColor();
            Console.WriteLine(message);
            SetDefaultColor();
        }
    }

    public static void SetErrorColor()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void SetEventColor()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    public static void SetDefaultColor()
    {
        Console.ResetColor();
    }
}

