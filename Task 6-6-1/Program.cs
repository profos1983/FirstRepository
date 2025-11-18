using System.ComponentModel.DataAnnotations;

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

        private string login;
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен содержать не менее 3 символов!.");
                }
                else login = value;
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
                if (value.Contains("@"))
                {
                    email = value;
                }
                else Console.WriteLine("Введите корректный адрес электронной почты!");
            }
        }
    }
}

