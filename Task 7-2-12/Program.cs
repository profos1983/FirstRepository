Obj obj1 = new Obj { Value = 10 };
Obj obj2 = new Obj { Value = 20 };

Obj obj3 = obj1 + obj2;
Obj obj4 = obj1 - obj2;

Console.WriteLine(obj3.Value);
Console.WriteLine(obj4.Value);

class Obj
{
    public int Value;

    public static Obj operator + (Obj x, Obj y)
    {
        return new Obj
        {
            Value = x.Value + y.Value
        };   
    }

    public static Obj operator - (Obj x, Obj y)
    {
        return new Obj
        {
            Value = x.Value - y.Value
        };
    }
}


//Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора 
//был новый экземпляр класса Obj, а операции производились над полем Value.
