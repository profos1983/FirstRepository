//Создайте классы для следующих объектов компьютера: процессор(Processor), материнская 
//карта(MotherBoard), видеокарта(GraphicCard).Унаследуйте их от класса ComputerPart.
//Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.

abstract class ComputerPart
{
    public abstract void Work();
}

class Processor: ComputerPart
{
    public override void Work()
    {
        Console.WriteLine("Процессор работает");
    }
}

class MotherBoard : ComputerPart
{
    public override void Work()
    {
        Console.WriteLine("Материнская плата работает");
    }
}

class GraphicCard : ComputerPart
{
    public override void Work()
    {
        Console.WriteLine("Видеокарта работает");
    }
}