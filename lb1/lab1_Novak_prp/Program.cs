using System;

class Program
{
    static void Main(string[] args)
    {
        Task1(); // Виклик функції для розв'язання Задачі 1
        Task2(); // Виклик функції для розв'язання Задачі 2
    }

    static void Task1()
    {
        // Задача 1: Знайти гіпотенузу та площу прямокутного трикутника
        Console.WriteLine("Задача 1: Знайти гіпотенузу та площу прямокутного трикутника");

        Console.WriteLine("Введіть довжину першого катета:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другого катета:");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"Гіпотенуза дорівнює: {c}");

        double area = (a * b) / 2;
        Console.WriteLine($"Площа трикутника дорівнює: {area}");
    }

    static void Task2()
    {
        // Задача 2: Знайти суму чисел, які належать інтервалу [x, y]
        Console.WriteLine("\nЗадача 2: Знайти суму чисел, які належать інтервалу [x, y]");

        Console.WriteLine("Введіть число a:");
        double numA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть число b:");
        double numB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть число c:");
        double numC = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть початок інтервалу x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть кінець інтервалу y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double sum = 0;

        if (x <= numA && numA <= y)
        {
            sum += numA;
        }

        if (x <= numB && numB <= y)
        {
            sum += numB;
        }

        if (x <= numC && numC <= y)
        {
            sum += numC;
        }

        Console.WriteLine($"Сума чисел, які належать інтервалу [{x}, {y}], дорівнює: {sum}");
    }
}
