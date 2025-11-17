//Описание задачи смотри файл ReadMe.txt

(string firstName, string lastName, int age, bool hasPet, int numberOfPet, string[] Pets, int numberOfFavourColors, string[] favourColors) user = new() ;

Console.Write("Введите свое имя: ");
user.lastName = Console.ReadLine();

Console.Write("Введите свою фамилию: ");
user.lastName = Console.ReadLine();
//do
//{
Console.Write("Введите свой возраст: ");
CheckDataAndSave(Console.ReadLine(), out user.age);


Console.Write("Есть ли у Вас питомцы? (Укажите Да/Нет) ");
string hasPetAnswer = Console.ReadLine();
if (hasPetAnswer == "Да") user.hasPet = true;
else user.hasPet = false;

if (user.hasPet == true)
{
    Console.Write("Укажите сколько у Вас питомцев: ");
    CheckDataAndSave(Console.ReadLine(), out user.numberOfPet);
    user.Pets = GetArray(user.numberOfPet);
}

Console.Write("Укажите, сколько у Вас любимых цветов: ");
CheckDataAndSave(Console.ReadLine(), out user.numberOfFavourColors);
user.favourColors = GetArray(user.numberOfFavourColors);



ShowUserData(user);


