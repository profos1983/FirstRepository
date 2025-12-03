NumberReader numberReader = new();
numberReader.NumberEnteredEvent += ShowNumber;
while (true)
{
    try
    {
        numberReader.Read();
    }

    catch (FormatException)
    {
        Console.WriteLine("Введенное значение не удовлетворяет условию (1 или 2)");
    }
}
static void ShowNumber(int number)
{
    switch (number)
    {
        case 1: Console.WriteLine("Введено значение: 1"); break;
        case 2: Console.WriteLine("Введено значение: 2"); break;
    }
}
