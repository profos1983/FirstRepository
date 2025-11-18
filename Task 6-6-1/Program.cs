class TrafficLight
{
    private string color;

    private void ChangeColor (string newcolor)
    {
        color = newcolor; 
    }

    public string GetColor()
    {
        return color;
    }

    class User
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (Email)
            }

        }
    }
}

