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

        string outputFilePath = "output_symbol.txt";
        ProcessFile(inputFilePath, outputFilePath);

        Console.WriteLine("Статистика була збережена у файлі: " + outputFilePath);
    }

    static void GenerateRandomNumbers(string filePath)
    {
        Random random = new Random();
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < 50; i++)
            {
                writer.WriteLine(random.Next(-10, 11));
            }
        }
    }

    static void ProcessFile(string inputFilePath, string outputFilePath)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int number = int.Parse(line);
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
