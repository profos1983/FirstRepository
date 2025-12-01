partial class Program
{
    public static int? SimpleCalc(int x, int y)
    {
        try
        {
            return x / y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null ;
        }
        finally
        {
            Console.WriteLine("Блок finally сработал!");
        }
    }   
}