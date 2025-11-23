
abstract class Delivery
{
    public string Address;

}

class HomeDelivery : Delivery
{
    /* ... */
}

class PickPointDelivery : Delivery
{
    /* ... */
}

class ShopDelivery : Delivery
{
    /* ... */
}

class Order<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    // ... Другие поля
}

abstract class Person
{
    #region Свойства
    protected string firstName;
    public string FirstName
    {
        get { return firstName; }
        internal set { firstName = value; }
    }

    protected string lastName;
    public string LastName
    {
        get { return lastName; }
        internal set { lastName = value; }
    }

    protected string adress;
    public string PersonAdress
    {
        get { return adress; }
        internal set { adress = value; }
    }

    string id;
    public virtual string Id
    {
        get { return id; }
        set { id = value; }
    }
    #endregion

    #region Методы
    public abstract void DisplayClassInfo();
    //{
    //    Console.WriteLine("Данные по учетной записи:\nИмя:{0}\nФамилия: {1}\nАдресс проживания: {2}", firstName, lastName, adress);
    //}
    #endregion
}


class Client : Person
    {
    #region Cвойства класса Клиент
    private string id;
    public override string Id
    {
        get { return Id; }
        set
        {
            if (value.Length == 10 && value.Substring(0, 2) == "ID")
            {
                Id = value;
            }
            else
            {
                Console.WriteLine("ID пользователя должно вводиться в виде: ID********, где * - любая цифра или буква");
            }

        }
    }
    #endregion

    #region Методы класса Клиент
    public override void DisplayClassInfo()
    {
        Console.WriteLine("Данные по учетной записи:\nИмя:{0}\nФамилия: {1}\nАдресс проживания: {2}", firstName, lastName, adress);
        Console.WriteLine("ID клиента: {0}", Id);
    }
    #endregion
}
