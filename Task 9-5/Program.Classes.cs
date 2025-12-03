partial class Program
{
    public class NumberReader
    {
        // Делегат
        public delegate void NumberEnteredDelegane(int number);
        public event NumberEnteredDelegane NumberEnteredEvent;
        
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите либо число 1, либо число 2:");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2)
            {
                throw new FormatException();
            }

            NumberEntered(number);

        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
