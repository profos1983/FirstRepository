int A = 12;
int B = 14;
double X = 12.4;
double Y = 45.4;
bool C = false;

C = (A < B) | (X > Y);

Console.WriteLine(C);

var a = 6;
var b = 7;

if (a != b)
{
    Console.WriteLine("Условие истинно");
}
else 
{
    Console.WriteLine("Условие ложно");
}

Console.WriteLine("Напишите свой любимый цвет на анклийском с маленькой буквы");
var defoultBackgroundColor = Console.BackgroundColor;
var defoultForegroundColor = Console.ForegroundColor;


var color = Console.ReadLine();

if (color == "red")
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine("Your color is red!");
}

else if (color == "green")
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine("Your color is green!");
}
else
{
    Console.BackgroundColor= ConsoleColor.Cyan;
    Console.ForegroundColor= ConsoleColor.Black;

    Console.WriteLine("Your color is cyan!");
}

Console.BackgroundColor = defoultBackgroundColor;
Console.ForegroundColor = defoultForegroundColor;

Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

switch (Console.ReadLine())
{
    case "red":
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Your color is red!");
    break;

    case "green":
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Your color is red!");
    break;

    case "cyan":
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Your color is cyan!");
        break;

    default:
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Default color is Yellow!");
        break;
}