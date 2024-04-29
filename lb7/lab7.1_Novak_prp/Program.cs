using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter("input.txt"))
            {
                sw.Write(text);
            }

            Console.WriteLine("Текст був успішно записаний у вхідний файл.");

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string content = sr.ReadToEnd();

                string editedText = Regex.Replace(content, @"\s+", " ");

                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    sw.Write(editedText);
                }

                Console.WriteLine("Вміст файлу був успішно відредагований.");

                using (StreamReader srOutput = new StreamReader("output.txt"))
                {
                    string outputText = srOutput.ReadToEnd();
                    Console.WriteLine("Вміст файлу output.txt:\n" + outputText);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Сталася помилка: " + e.Message);
        }
    }
}
