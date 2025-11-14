
// Информация о юзере в виде кортежа
(string firstName, string lastName, string login, int loginLenght, bool hasPet, double petAge, string[] freeFavourColors ) user;


for (int i = 0; i < 3; i++)
{
    Console.Write("Введите имя: ");
    user.firstName = Console.ReadLine();

    Console.Write("Введите фамилию: ");
    user.lastName = Console.ReadLine();

    Console.Write("Введите логин: ");
    user.login = Console.ReadLine();

    user.loginLenght = user.login.Length;

    Console.Write("Введите есть ли у Вас питомец (Да/Нет): ");
    string result = Console.ReadLine();
    if (result == "Да")
    {
        user.hasPet = true;
    }
    else
    {
        user.hasPet = false;
    }

    if (user.hasPet == true)
    {
        Console.Write("Введите возраст питомца: ");
        user.petAge = Convert.ToInt32(Console.ReadLine());
    }
    else user.petAge = 0;

    user.freeFavourColors = new string[3];
    for (int i2 = 0; i2 < 3; i2++)
    {
        int colorNumber = i2 + 1;
        Console.Write("Напишите свой " + colorNumber + " любимый цвет: ");

        user.freeFavourColors[i2] = Console.ReadLine();
    }


    Console.WriteLine(
        user.firstName + " "
         + " " + user.lastName
         + " " + user.login
         + " " + user.loginLenght
         + " " + user.hasPet
         + " " + user.petAge
         + " " + user.freeFavourColors[0]
         + " " + user.freeFavourColors[1]
         + " " + user.freeFavourColors[2]);
}
