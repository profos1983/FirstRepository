int val = 8;

static void Main(string[] args)
{

    int val = 10;
    Doubled(ref val);
    Console.WriteLine(val);
    Console.ReadKey();
}

static void Doubled(ref int val)
{
    val *= 2;
}
