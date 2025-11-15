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

( string firstName, string lastName, int age, bool hasPet, int numberOfPet, string[] Pets, int numberOfFavourColors, string[] favourColors ) user;

Console.Write("Введите свое имя: ");
user.lastName = Console.ReadLine();

Console.Write("Введите свою фамилию: ");
user.lastName = Console.ReadLine();
//do
//{
Console.Write("Введите свой возраст: ");
string ageInString = Console.ReadLine();


if(int.TryParse(ageInString, out user.age))
{
    Console.WriteLine("Вы ввели корректное число.");
}
else do
{
        Console.WriteLine("Вы ввели не верное число. Попробуйте еще раз.");
        ageInString = Console.ReadLine();
}
while(int.TryParse(ageInString, out user.age) == false);


    //}
    //while (CorrectData(user.age) == false);






//    Console.Write("Есть ли у Вас питомец? (Укажите Да/Нет) ");
//string hasPetAnswer = Console.ReadLine();
//if ( hasPetAnswer == "Да" ) user.hasPet = true;
//else user.hasPet = false;

//if (user.hasPet == true)
//{
//    Console.Write("Укажите сколько у Вас питомцев: ");
//    us
//}



