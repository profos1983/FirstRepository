using System.Runtime.CompilerServices;
using static Program;

partial class Program
{
    /// <summary>
    /// Делегат, который отслеживает ввод пользователем числа
    /// </summary>
    /// <param name="number">Число, введенное пользователем</param>
    public delegate void UserChoiceNumber(int chosenNumber);
    public class ListOfPersons
    {
        private string[] listOfPersons;

        // Медот, который будет реагировать на введенное пользователем число через делегат и событие.
        public void OnUserChoiceNumber(int number)
        {
            switch (number)
            {
                case 0:
                    this.CreateList();
                    Console.WriteLine();
                    Console.WriteLine("Введенный Вами список пользователей");
                    this.PrintList();
                    break;
                case 1:
                    this.SortList();
                    Console.WriteLine();
                    Console.WriteLine("Список пользователей после сортировки А-Я");
                    this.PrintList();
                    break;
                case 2:
                    this.ReverseSort();
                    Console.WriteLine();
                    Console.WriteLine("Список пользователей после сортировки Я-А");
                    this.PrintList();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Введенный Вами список пользователей");
                    this.PrintList();
                    break;
            }
        }

        public void CreateList()
        {
            listOfPersons = new string[5];
            int num = 1;
            Console.WriteLine("Введите массив из пяти фамилий пользователей\n(Не менее двух символов Русского алфавита(цифры и символы не допускаются):");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите имя " + num + " пользователя: ");
                listOfPersons[i] = Console.ReadLine();
                num++;
            }
        }

        public void PrintList()
        {
            Console.WriteLine("=================================");
            foreach (string s in listOfPersons)
            {
                Console.WriteLine(s);
            }
        }

        public void SortList()
        {
            Array.Sort(listOfPersons);
        }

        public void ReverseSort()
        {
            Array.Reverse(listOfPersons);
        }

        public bool ListIsNull()
        {
            if (listOfPersons == null)
            {
                return true;
            }
            else return false;
        }
    }

    /// <summary>
    /// Класс, который генерирует событие ввода числа пользователем.
    /// </summary>
    public class UserChoice
    {
        // Объявляем событие выбора числа пользователем.
        public event UserChoiceNumber ChoiceNumber;
        private int number;
        public int Number
        {
            get
            {
                return number; 
            }
            set
            {
                number = value;
                //Публикация введенного пользователем числа.
                if (value >= 0 && value <= 3)
                    ChoiceNumber?.Invoke(number);
            }
        }    
    }

    public static void Cleanconsole() 
    {
        Console.Write("Введете любой символ для возврата в меню");
        Console.ReadKey();
        Console.Clear();
    }
}
