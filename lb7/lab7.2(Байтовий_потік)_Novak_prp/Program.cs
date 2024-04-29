using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        GenerateRandomNumbers(inputFilePath);

        string outputFilePath = "output_byte.txt";
        ProcessFile(inputFilePath, outputFilePath);

        Console.WriteLine("Статистика була збережена у файлі: " + outputFilePath);
    }

    static void GenerateRandomNumbers(string filePath)
    {
        Random random = new Random();
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            for (int i = 0; i < 50; i++)
            {
                writer.Write(random.Next(-10, 11));
            }
        }
    }

    static void ProcessFile(string inputFilePath, string outputFilePath)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        using (FileStream fs = new FileStream(inputFilePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            while (fs.Position < fs.Length)
            {
                int number = reader.ReadInt32();
                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (var entry in frequencyMap)
            {
                writer.WriteLine($"{entry.Key}, {entry.Value}");
                Console.WriteLine($"{entry.Key}, {entry.Value}");
            }
        }
    }
}
