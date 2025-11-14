( string name, string[]  favourMeels ) user;

Console.WriteLine("Введите Ваше имя: ");
user.name = Console.ReadLine();

user.favourMeels = new string[5];

for ( int i = 0; i < 5; i++ )
{
    int meelNumber = i + 1;
    Console.WriteLine("Введите свое " + meelNumber + "любимое блюдо.");
    user.favourMeels[i] = Console.ReadLine();
}

Console.WriteLine(
         "Имя: " + user.name + " "
         + "1 блюдо " + user.favourMeels[0]
         + "2 блюдо " + user.favourMeels[1]
         + "3 блюдо " + user.favourMeels[2]
         + "4 блюдо " + user.favourMeels[3]
         + "5 блюдо " + user.favourMeels[4]);