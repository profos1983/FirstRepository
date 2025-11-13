Console.WriteLine("Введите свое имя:");

string name = Console.ReadLine();
int lenghtName = name.Length;

Console.WriteLine("Ваше имя по буквам:");

for(int i = 0; i <  lenghtName; i++)
{
    Console.Write(name[i]);
    Console.Write(" ");

    if (i == lenghtName - 1)
    {
        Console.Write("Последняя буква Вашего имени: ");
        Console.WriteLine(name[i]);
    }
}

for (int i = lenghtName -1; i >= 0; i--)
{
    Console.Write(name[i]);
}