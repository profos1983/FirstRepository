//Напишите метод, который считает количество файлов и папок в 
//корне вашего диска и выводит итоговое количество объектов.

partial class Program
{
    public static void GetNumberOfDirectoriesAndFiles()
    {
        try
        {
            string dirName = "C:\\";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (dirInfo.Exists)
            {
                Console.WriteLine($"Количество каталогов: {dirInfo.GetDirectories().Length}\nКоличество файлов: {dirInfo.GetFiles().Length}");
                //Console.WriteLine("Каталоги:");

                //for (int i = 0; i < directories.Length; i++)
                //{
                //    Console.WriteLine($"{directories[i]}    ");
                //}

                //foreach(string directory in directories)
                //{
                //    if (directories.Length % 3 == 0)
                //    {
                //        Console.WriteLine();
                //        Console.Write($"{directory}    ");
                //    }
                //    else Console.Write($"{directory}    ");
                //}
            }
            else Console.WriteLine("Папка не существует");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
}