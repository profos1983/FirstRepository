Exception myException = new("Мое собственное исключение");
myException.Data.Add("Дата создания исключения: ", DateTime.Now);
myException.HelpLink = "www.ya.ru";

int x = 11;
int y = 0;
int? z = SimpleCalc(x, y);
Console.WriteLine( "z равен: " + (z.HasValue ? z: "null"));

try
{
    throw new ArgumentOutOfRangeException();
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Срабатывание блока finally.");
}

try
{
    throw new RankException();
}
catch (RankException ex)
{
    Console.WriteLine(ex.GetType());
}
finally
{
    Console.WriteLine("Срабатывание блока finally.");
}