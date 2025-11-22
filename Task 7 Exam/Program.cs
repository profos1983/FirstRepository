
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
    private string firstName;
    public string FirstName
    {
        get { return firstName; }
        internal set { firstName = value; }
    }

    private string lastName;
    public string LastName
    {
        get { return lastName; }
        internal set { lastName = value; }
    }

    private string adress;
    public string PersonAdress
    {
        get { return adress; }
        internal set { adress = value; }
    }
}


    class Client : Person
    {
        private string clientId;
        public string ClientId
    {
            get { return clientId; }
            protected set
            {
                if (value.Length == 10 && value.Substring(0, 2) == "ID")
                {
                    clientId = value;
                }
                else
                {
                    Console.WriteLine("ID пользователя должно вводиться в виде: ID********, где * - любая цифра или буква");
                }

            }
        }

    }
