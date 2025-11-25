
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
            if (value.Length == 18 && value.Substring(0, 8) == "ClientID")
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

class Custumer: Person
{
    #region Свойства класса Сотридник
    static double minimumWage = 20000;
    protected string jobTitle;
        public string JobTitle
    {
        get { return jobTitle; }
        set { jobTitle = value; }
    }
    public override string Id
    {
        get { return Id; }
        set
        {
            if (value.Length == 20 && value.Substring(0, 10) == "CustumerID")
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

    #region Методы класса Сотридник
    public override void DisplayClassInfo()
    {
        Console.WriteLine("Данные по учетной записи:\nИмя:{0}\nФамилия: {1}\nАдресс проживания: {2}", firstName, lastName, adress);
        Console.WriteLine("ID сотрудника: {0}", Id);
        Console.WriteLine("Должность сотрудника: {0}", jobTitle);
    }
    #endregion

}

class Manager : Custumer
{
    #region Свойства класса Менеджер
    string[] ListOfProject;
    public override string Id
    {
        get { return Id; }
        set
        {
            if (value.Length == 20 && value.Substring(0, 9) == "ManagerID")
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

    #region Конструкторы класса Менеджер
    Manager (string firstName = "Unknown", string lastName = "Unknown")
    {
        this.firstName = lastName;
        this.lastName = firstName;
    }
    #endregion

    #region Методы класса Менеджер
    public override void DisplayClassInfo()
    {
        Console.WriteLine("Данные по учетной записи:\nИмя:{0}\nФамилия: {1}\nАдресс проживания: {2}", firstName, lastName, adress);
        Console.WriteLine("ID сотрудника: {0}", Id);
        Console.WriteLine("Должность сотрудника: {0}", jobTitle);
    }
    #endregion
}

public class ClientСhoosingDeliveryMethod<TDelivery>
{
    public TDelivery Delivery { get; set; }
}