partial class Program 
{
    static void GetName(ref string name) 
    {
        Console.WriteLine("Введите имя: ");
        name = Console.ReadLine();
    }
    
    static void ChangeAge(ref double age)
    {
        Console.WriteLine("Введите Ваш возраст");
        age = double.Parse(Console.ReadLine());
    }

    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
    }

    static int[] GetArrayFromConsole(ref int numberInArray)
    {

        var array = new int[numberInArray];
        int number = 0;

        for (int i = 0; i < numberInArray; i++)
        {
            number = i + 1;
            Console.Write("Введите " + number + "число в массиве: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }
    
    // Заполнения одномерного массива целых чисел.
    static int[] GetArrayFromConsole(int numberInArray = 5)
    {

        var array = new int[numberInArray];
        int number = 0;

        for (int i = 0; i < numberInArray; i++)
        {
            number = i + 1;
            Console.Write("Введите " + number + "число в массиве: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    // Сортировка массива от большего к меньшему
    static int[] SortArrayDesc(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        return array;
    }

    // Сортировка массива от меньшего к большему
    static int[] SortArrayAsc(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        return array;
    }

    static void SortArray(in int[] array, out int[] descArray, out int[] ascArray)
    {

        descArray = (int[])array.Clone();
        ascArray = (int[])array.Clone();

        SortArrayDesc(descArray);
        SortArrayAsc(ascArray);
    }

    // Вывод массива на экран
    static void ShowArray(int[] array)
    {

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}


