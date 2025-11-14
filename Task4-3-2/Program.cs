//int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10}, {11, 12, 13 } };
//Console.WriteLine(array.Length);

//foreach(var item in array)
//{
//    Console.Write(item + " ");
//}

//int kSt = array.GetUpperBound(0) + 1;
//int kStb = array.GetUpperBound(1) + 1;

//Console.WriteLine("Количество строк: " + kSt );
//Console.WriteLine("Количество столбцов: " + kStb);


//for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
//{
//    for(int k = 0 ; k < array.GetUpperBound(0) + 1; k++)
//    {
//        Console.Write(array[k, i] + " ");
//    }

//    Console.WriteLine();
//}

//Console.WriteLine("Сортировка массива");
//var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

//int temp = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] > arr[j]) 
//        {
//            temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }  
//    }
//}

//foreach (var item in arr)
//{
//    Console.Write(item);
//}

//Console.WriteLine("Сумма всех элементов массива");
//var arrForSumm = new int[] { 5, 6, 9, 1, 2, 3, 4 };

//int summ = 0;

//foreach (var item in arrForSumm) 
//    {
//        summ += item;
//    }

//Console.WriteLine("Сумма всех элементов массива: " + summ);

//Console.WriteLine("Зубчатые массивы");

//int[][] array2 = new int[3][];

//array2[0] = new int[2] { 1, 2 };
//array2[1] = new int[3] { 1, 2, 3 };
//array2[2] = new int[5] { 1, 2, 3, 4, 5 };

//foreach (var num in array2) 
//{
//    foreach (var item in num) 
//    {
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Поиск поличества положительных чисел в массиве");

//var arr3 = new int[] { 5, 6, -9, -1, 2, -3, 4 };
//int sumPositive = 0;

//for (int i = 0; i < arr3.Length; i++) 
//{
//    if (arr3[i] > 0)
//    {
//        sumPositive++; 
//    }
//}

//Console.WriteLine("Количнство положительных чисел в массиве: " + sumPositive);


Console.WriteLine("Поиск поличества положительных чисел в двумерном массиве");
int[,] arr4 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

int sumPositive = 0;

int kSt4 = arr4.GetUpperBound(0) + 1;
int kStb4 = arr4.GetUpperBound(1) + 1;

Console.WriteLine("Количество строк: " + kSt4);
Console.WriteLine("Количество столбцов: " + kStb4);

for (int i = 0; i < arr4.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < arr4.GetUpperBound(1) + 1; j++ )
    {
        if (arr4[i, j] > 0) 
        {
            sumPositive++;
        }
    }
}

Console.WriteLine("Количество положительных чисел в двухмерном массиве: " + sumPositive);