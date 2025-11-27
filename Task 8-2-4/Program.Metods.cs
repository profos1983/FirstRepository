partial class Program
{
    //Создайте на рабочем столе папку testFolder. Напишите метод, с помощью которого можно 
    //будет переместить её в корзину. 

    public static void CreateFolder()
    {
        try
        {
            string path = "C:\\Users\\Алексей\\Desktop\\testFolder";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else Console.WriteLine("Папка уже существует!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
        }
    }

    public static void RemoveFolder()
    {
        try
        {
            string path = "C:\\Users\\Алексей\\Desktop\\testFolder";
            string pathToRecycle = "C:\\$Recycle.Bin\\testFolder";
            DirectoryInfo moveFolder = new(path);
            if (moveFolder.Exists)
            {
                moveFolder.MoveTo(pathToRecycle);
            }
            else Console.WriteLine("Папка уже перемещана или не существует!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

