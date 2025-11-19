class Obj
{
    public string Name;
    public string Description;
    public string int MaxValue = 2000;
   
}

class Counter
{
    private static int increasingCounter;
    public static int IncreasingCounter
    {
        get { return increasingCounter; } 
        set 
        {
            if (increasingCounter > value)
            {
                increasingCounter = value;
            }
        }
    }
}
