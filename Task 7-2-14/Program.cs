
IndexingClass array1 = new IndexingClass (new int[]  { 1, 2, 3 });
array1 [0] = 25; // Запись по индексатору
array1 [15] = 25; // Запись по индексатору, с ошибкой

int value = array1[2];
int value2 = array1[23];

Console.WriteLine(value);
Console.WriteLine(array1[0]);

Console.WriteLine(value2);
Console.WriteLine(array1[23]);
class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    // Индексатор по массиву
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                Console.WriteLine("Индекс получаемого значения выходит за границы массива");
                return 0;
            }
        }

        set
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
            else Console.WriteLine("Индекс элеметна в который Вы пытаетесь записать данные выходят за границы массива");
        }
    }
}

//Для следующего класса напишите индексатор, для типа параметра используйте int:
