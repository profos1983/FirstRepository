
//string name = "Евгения";
//Console.WriteLine(name);

//GetName(ref name);

//Console.WriteLine(name);

//double age = 5.4;
//Console.WriteLine(age);

//ChangeAge(ref age);
//Console.WriteLine(age);

//var arr = new int[] { 1, 2, 3 };
//BigDataOperation(arr);

//Console.WriteLine(arr[0]);


int[] arrayTest = GetArrayFromConsole(3);
Console.Write("Неотсортированный массив: ");
ShowArray(arrayTest);
Console.WriteLine();

int[] arrayDesc = new int[3];
int[] arrayAsc = new int[3];

SortArray(in arrayTest,out arrayDesc,out arrayAsc);

Console.Write("от большего к меньшему: ");
ShowArray(arrayDesc);
Console.WriteLine();

Console.Write("от меньшего к большему: ");
ShowArray(arrayAsc);

