using System;

class Program
{
    static void Main(string[] args)
    {
        Task1(); // Виклик функції для розв'язання Завдання 1
        Task2(); // Виклик функції для розв'язання Завдання 2
        Task3(); // Виклик функції для розв'язання Завдання 3
        Task4(); // Виклик функції для розв'язання Завдання 4
    }

    static void Task1()
    {
        Console.WriteLine("Завдання 1: Обчислення кількості робітників, які не виконали денне завдання");

        int[] productsProduced = { 40, 35, 37, 32, 38 }; // Приклад

        int plan = 37;
        int workersNotMeetPlan = 0;

        foreach (int products in productsProduced)
        {
            if (products < plan)
            {
                workersNotMeetPlan++;
            }
        }

        Console.WriteLine($"Кількість робітників, які не виконали денне завдання: {workersNotMeetPlan}");
    }

    static void Task2()
    {
        Console.WriteLine("\nЗавдання 2: Обчислення середнього геометричного для кожного стовпця матриці");

        double[,] matrix = {
            { 1.5, 2.5, 3.5 },
            { 4.5, 5.5, 6.5 },
            { 7.5, 8.5, 9.5 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[] geometricMeans = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            double product = 1.0;

            for (int i = 0; i < rows; i++)
            {
                product *= matrix[i, j];
            }

            geometricMeans[j] = Math.Pow(product, 1.0 / rows);
        }

        Console.WriteLine("Середнє геометричне для кожного стовпця матриці:");
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"Стовпець {j + 1}: {geometricMeans[j]}");
        }
    }

    static void Task3()
    {
        Console.WriteLine("\nЗавдання 3: Операції над матрицями");

        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double scalar = 2.5;

        Console.WriteLine("Матриця до множення на число:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Матриця після множення на число {scalar}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] * scalar + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Task4()
    {
        Console.WriteLine("\nЗавдання 4: Робота зі списком груп та студентів");

        string[,] groups = {
            { "1", "Group 1" },
            { "2", "Group 2" },
            { "3", "Group 3" }
        };

        string[,] students = {
            { "1", "John Doe", "1" },
            { "2", "Jane Smith", "2" },
            { "3", "Alice Johnson", "1" },
            { "4", "Bob Brown", "3" }
        };

        Console.WriteLine("Список студентів з назвами їх груп:");
        for (int i = 0; i < students.GetLength(0); i++)
        {
            string studentName = students[i, 1];
            string groupName = "";

            for (int j = 0; j < groups.GetLength(0); j++)
            {
                if (groups[j, 0] == students[i, 2])
                {
                    groupName = groups[j, 1];
                    break;
                }
            }

            Console.WriteLine($"{studentName} - {groupName}");
        }

        Console.WriteLine("\nСписок студентів конкретної групи (Group 1):");
        for (int i = 0; i < students.GetLength(0); i++)
        {
            if (students[i, 2] == "1")
            {
                Console.WriteLine(students[i, 1]);
            }
        }
    }
}