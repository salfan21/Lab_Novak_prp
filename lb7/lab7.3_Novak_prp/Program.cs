using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть шлях до каталогу:");
        string directoryPath = Console.ReadLine();

        if (Directory.Exists(directoryPath))
        {
            ProcessDirectory(directoryPath);
            Console.WriteLine("Операція завершена.");
        }
        else
        {
            Console.WriteLine("Каталог не знайдено.");
        }
    }

    static void ProcessDirectory(string directoryPath)
    {
        DirectoryInfo directory = new DirectoryInfo(directoryPath);

        foreach (FileInfo file in directory.GetFiles())
        {
            DateTime createdDate = file.CreationTime.Date;

            string subDirectoryPath = Path.Combine(directory.FullName, createdDate.ToString("yyyy-MM-dd"));

            Directory.CreateDirectory(subDirectoryPath);

            string newFilePath = Path.Combine(subDirectoryPath, file.Name);

            file.MoveTo(newFilePath);
        }
    }
}
