DriveInfo[] drives = DriveInfo.GetDrives();
foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Название диска:    {drive.Name}.");
    Console.WriteLine($"     Тип диска:    {drive.DriveType}.");
    
    if (drive.IsReady)
    {
        Console.WriteLine($"         Объем:    {drive.TotalSize}");
        Console.WriteLine($"      Свободно:    {drive.TotalFreeSpace}");
        Console.WriteLine($"         Метка:    {drive.VolumeLabel}");
    }
    Console.WriteLine("");
}
