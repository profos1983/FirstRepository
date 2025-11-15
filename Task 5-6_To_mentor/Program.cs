//Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
//Имя;
//Фамилия;
//Возраст;
//Наличие питомца;
//Если питомец есть, то запросить количество питомцев;
//Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
//Запросить количество любимых цветов;
//Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
//Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
//Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
//Корректный ввод: ввод числа типа int больше 0.
//Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
//Вызов методов из метода Main.

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


