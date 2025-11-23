//Counter.IncreasingCounter = 1;
//Console.WriteLine(Counter.IncreasingCounter);

//Counter.IncreasingCounter = 5;
//Console.WriteLine(Counter.IncreasingCounter);

//Counter.IncreasingCounter ++;
//Console.WriteLine(Counter.IncreasingCounter);

int num1 = 3;
int num2 = 58;



Console.WriteLine("num1 = {0}, num2 = {1}",num1, num2);

class Obj
{
    public string? Name;
    public string? Description;
    public static int MaxValue = 2000;
   
}

class Counter
{
    private static int increasingCounter;
    public static int IncreasingCounter
    {
        get { return increasingCounter; } 
        set 
        {
            if (value > increasingCounter)
            {
                increasingCounter = value;
            }
        }
    }
}


