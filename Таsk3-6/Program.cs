

double result = (double) 5 / (double) 2;
Console.WriteLine("5 / 2 = {0}",
    arg0: result);

int counter = 10;
Console.WriteLine("Value: {0} Increment: {1}",
    arg0: counter,
    arg1: counter++);

double result2 = 10 % 3;
Console.WriteLine("Результат вычисления остатка от деления 10 % 3 = {0}",
    arg0: result2);

Console.Write("Введите Ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите Ваш возраст: ");
byte age = checked (byte.Parse(Console.ReadLine()));
Console.Write("Какой ваш самый любимый день недели?");
DayOfWeek favouritDay = (DayOfWeek) int.Parse(Console.ReadLine());
Console.Write("Your favourite day is {0}", favouritDay);

Console.WriteLine((int) favouritDay);

enum DayOfWeek: int
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
};
