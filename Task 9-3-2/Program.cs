//Задание 9.3.2
//Создайте консольное приложение, в котором есть функция, принимающая на вход 
//два числа int, и возвращающая результат int вычитания второго числа из первого. 
//Вызовите эту функцию в классе Main при помощи делегата и отобразите результат 
//в консольном сообщении.
DelegateXplusY test1 = XminusY;
int z = test1.Invoke(5, 6);
int z2 = test1(23, 4);

Console.WriteLine(z);
Console.WriteLine(z2);
public delegate int DelegateXplusY (int  x, int y);
