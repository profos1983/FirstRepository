partial class Program
{
    static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }

    public static void Calc3(int x, int y, out int? z )
    {
        try
        {
            z = x / y;
        }   
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            z = null;
        }
    }
}
