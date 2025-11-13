(string name, int age) anketa;

Console.Write("Напишите свое имя: ");
anketa.name = Console.ReadLine();
Console.Write("Напишите свой возраст: ");
anketa.age = int.Parse(Console.ReadLine());

Console.WriteLine("Выше имя: {0}, Ваш возраст: {1}. Приятно познакомиться!", anketa.name, anketa.age);
