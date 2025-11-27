//Напишите программу, которая выводит свой собственный исходный код в консоль.

string pathToFile = "C:\\repos\\FirstRepository\\Task 8-3-1\\Program.cs";

using (StreamReader sr = File.OpenText(pathToFile))
{
    string str = "";
    while((str = sr.ReadLine()) != null)
    {
        Console.WriteLine(str);
    }
}