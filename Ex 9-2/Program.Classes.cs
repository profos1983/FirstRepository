using static Program;

partial class Program
{
    public class ListOfPersons
    {
        private string[] listOfPersons;

        public void CreateList()
        {
            listOfPersons = new string[5];
            int num = 1;
            Console.WriteLine("Введите массив из пяти фамилий пользователей\n(Не менее двух символов Русского алфавита(цифры и символы не допускаются):");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя " + num + " пользователя.");
                listOfPersons[i] = Console.ReadLine();
                num++;
            }
        }

        public void PrintList()
        {
            Console.WriteLine("Введеный список пользователей:");
            Console.WriteLine("==============================");
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
    }
}
