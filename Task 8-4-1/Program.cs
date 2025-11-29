//По ссылке лежит бинарный файл. В нём записана дата создания и имя операционной системы, на 
//которой он был создан (формат данных — строка).
//Скачайте файл и поместите его на рабочий стол.
//Напишите программу, которая считает из него данные и позволит вам ответить на следующие вопросы:
//1.Когда файл был создан?
//2. На какой операционной системе создан файл?
using System.Formats.Asn1;
using System.IO;

const string path = "BinaryFile.bin";
if (!File.Exists(path))
{
    File.Create(path).Close();
}

string stringRead = null;
try
{
    if (File.Exists(path))
    {
        using (BinaryReader binReader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
     
            while ( binReader.PeekChar() != -1)
            {
                stringRead = binReader.ReadString();
                Console.WriteLine("Строка: " + stringRead);                
            }
        }

        //Запишите в файл из предыдущего задания информацию о доступе к нему с вашей машиныю
        //Пример вывода, который должен получиться: 
        //Файл изменен 02.11 14:53 на компьютере Windows 11

        using (BinaryWriter binWriter = new BinaryWriter(File.Open(path, FileMode.Append)))
        {
            DateTime writeTime = DateTime.Now;
            string osAndVersion = Environment.OSVersion.Platform.ToString() + " " + Environment.OSVersion.Version.ToString();
            binWriter.Write("Файл записан " + writeTime + "на компьютеру под  управлением " + osAndVersion);
        }
    }
    else Console.WriteLine("Файл не существует!");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


