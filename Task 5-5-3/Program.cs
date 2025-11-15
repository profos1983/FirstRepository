//Console.WriteLine("Напишите что-то");
//var str = Console.ReadLine();

//Console.WriteLine("Укажите глубину эха");
//var deep = int.Parse(Console.ReadLine());
//var defoultColor = Console.BackgroundColor;

//Echo(str, deep);

//Console.ReadKey();

//static void Echo(string saidworld, int deep)
//{
//    var modif = saidworld;
//    if (modif.Length > 2)
//    {
//        Console.BackgroundColor = (ConsoleColor)deep;
//        modif = modif.Remove(0, 2);
//    }
//    Console.WriteLine("..." + modif);
//    if (deep > 1)
//    {
//        Echo(modif, deep - 1);
//    }
//}

//Console.WriteLine(Factorial(20));
//static int Factorial(int x)
//{
//    if (x == 0)
//    {
//        return 1;
//    }
//    else
//    {
//        return x * Factorial(x - 1);
//    }
//}
Console.WriteLine(PowerUp(4, 4));
static int PowerUp (int N, byte pow)
{
    if (pow == 0)
    {
        return 1;
    }
    else if (pow == 1)
    {
        return N;
    }


    {
        return N * PowerUp(N, --pow);
    }
}
