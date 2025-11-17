partial class Program
{
    public class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load != null)
            {
                Console.WriteLine("Количество пассажиров: {0}", Load);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }

        public void PrintStatusV2()
        {
            if (Load.HasValue && Load>0)
            {
                Console.WriteLine("Количество пассажиров: {0}", Load);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }
    }
}