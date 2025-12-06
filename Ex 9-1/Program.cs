using static Program;

Exception[] myExceptions = new Exception[]
{
    new FormatException(),
    new NotImplementedException(),
    new MyOverflowException(),
    new DriveNotFoundException(),
    new FileNotFoundException()
};

Console.WriteLine("Вызов всех исключений в массиве myExceptions:");
foreach(Exception exception in myExceptions)
{
    try
    {
        throw (exception);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (NotImplementedException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (MyOverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (DriveNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
