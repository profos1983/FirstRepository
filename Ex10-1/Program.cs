using System.Diagnostics;

ILogger logger = new Logger();
SumCalculator sumCalc = new SumCalculator(logger);

Console.WriteLine("Простейший калькулятор для сложения двух целых чисел чисел.");
Console.WriteLine("===============================================");
while (true)
{
    Console.Write("Для рассчета суммы двух чисел введите - Да, для завершения программы введите - Нет ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "Да":
            sumCalc.SetX();
            sumCalc.SetY(); 

            Console.WriteLine($"Сумма двух введенных чисел: {sumCalc.Sum()}");
        break;

        case "Нет": return;

        default: 
            Console.WriteLine("Необходимо ввести либо - Да, либо - Нет");
            break;
    }
  
}
