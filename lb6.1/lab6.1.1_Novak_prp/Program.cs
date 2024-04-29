using System;

public class Program
{
    public delegate bool CheckCondition(int number);

    public static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 4, 8, 16, 17, 32, 64, 100 };

        int[] powersOfTwo = FilterArray(numbers, IsPowerOfTwo);
        Console.WriteLine("Числа, які є ступенями числа 2:");
        foreach (int num in powersOfTwo)
        {
            Console.WriteLine(num);
        }

        int[] twoDigitNumbers = FilterArray(numbers, IsTwoDigitNumber);
        Console.WriteLine("\nДвозначні числа в масиві:");
        foreach (int num in twoDigitNumbers)
        {
            Console.WriteLine(num);
        }
    }

    public static int[] FilterArray(int[] numbers, CheckCondition condition)
    {
        int[] result = new int[numbers.Length];
        int index = 0;
        foreach (int num in numbers)
        {
            if (condition(num))
            {
                result[index++] = num;
            }
        }
        Array.Resize(ref result, index);
        return result;
    }

    public static bool IsPowerOfTwo(int number)
    {
        return (number != 0) && ((number & (number - 1)) == 0);
    }

    public static bool IsTwoDigitNumber(int number)
    {
        return number >= 10 && number <= 99;
    }
}