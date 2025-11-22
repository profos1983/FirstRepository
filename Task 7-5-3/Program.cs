class Helper
{
    public static void Swap(ref int a, ref int b)
    {
        int c = b;
        b = a;
        a = c;
    }
}
