

//GetArrayFromConsole();

//(string name, int age) anketa;

//Console.Write("Напишите свое имя: ");
//anketa.name = Console.ReadLine();
//Console.Write("Напишите свой возраст: ");
//anketa.age = int.Parse(Console.ReadLine());


//Console.WriteLine("Выше имя: {0}, Ваш возраст: {1}. Приятно познакомиться!", anketa.name, anketa.age);

//string[] favourColors = new string[3];

//for (int i = 0; i < favourColors.Length; i++)
//{
//    favourColors[i] = ShowColor(anketa.name, anketa.age);
//}

//string[] favourColors = new string[3];

//for (int i = 0; i < favourColors.Length; i++)
//{

//    favourColors[i] = ShowColor(anketa.name, anketa.age);
//}

//int[] testArray = GetArrayFromConsole();

//SortArray(testArray);

//PrintArray(testArray);

////ShowColors(anketa.name, favourColors);

var array = GetArrayFromConsole(10);
ShowArray(array,true);
