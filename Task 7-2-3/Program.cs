
DerivedClass one = new();
one.Display();

DerivedClass2 two = new();
two.Counter = 10;


class BaseClacc
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass: BaseClacc
{
    
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }

}

class BaseClass2
{
    public virtual int Counter { get; set; }
}

class DerivedClass2 : BaseClass2
{
    public int counter;
    public override int Counter
    {
        get
        {
            return counter;
        }

        set
        {
            if (value >= 0)
            {
                counter = value;
            }
            else
            {
                Console.WriteLine("Вводимое число должно быть больше или равно нулю");
            }
        }
    }
}
