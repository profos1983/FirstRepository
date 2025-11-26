//Напишите метод, который считает количество файлов и папок в 
//корне вашего диска и выводит итоговое количество объектов.

//Добавьте в метод из задания 8.2.1 создание новой директории в корне 
//вашего диска, а после вновь выведите количество элементов уже 
//после создания нового. 

//Убедитесь, что их количество увеличилось, либо корректно вывелось 
//сообщение об ошибке (если у вас нет прав на запись).

using System.Runtime;

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
                //DirectoryInfo[] directories = dirInfo.GetDirectories();


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

                string dirNameForCreate = "C:\\Test123\\";
                DirectoryInfo dirInfoForCreatDir = new DirectoryInfo(dirNameForCreate);

                if (!dirInfoForCreatDir.Exists)
                {
                    dirInfoForCreatDir.Create();
                    Console.WriteLine("Каталог создан!");
                }
                else Console.WriteLine("Папка уже существует!");

                Console.WriteLine($"Количество каталогов: {dirInfo.GetDirectories().Length}\nКоличество файлов: {dirInfo.GetFiles().Length}");

                dirInfoForCreatDir.Delete(true);
                Console.WriteLine("Каталог удален!");

            }
            else Console.WriteLine("Папка не существует");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
}