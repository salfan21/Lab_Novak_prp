using System;

public class Data
{
    private int value;

    public Data()
    {
        this.value = 0;
    }

    public Data(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("value", "Значення не може бути від'ємним");
        }
        this.value = value;
    }

    public static Data operator +(Data d1, Data d2)
    {
        return new Data(d1.value + d2.value);
    }

    public static Data operator -(Data d1, Data d2)
    {
        if (d1.value < d2.value)
        {
            throw new InvalidOperationException("Перше значення менше за друге");
        }
        return new Data(d1.value - d2.value);
    }

    public static Data operator --(Data d)
    {
        if (d.value == 0)
        {
            throw new InvalidOperationException("Неможливо відняти 1 від нульового значення");
        }
        return new Data(d.value - 1);
    }

    public override string ToString()
    {
        return value.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Data d1 = new Data(10);
            Data d2 = new Data(5);

            Data sum = d1 + d2;
            Data difference = d1 - d2;

            Console.WriteLine("Сума: " + sum);
            Console.WriteLine("Різниця: " + difference);

            Data d3 = new Data(3);
            Data result = d3 - d1;
            Console.WriteLine("Результат: " + result);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Внутрішня помилка: " + ex.Message);
        }

        Console.ReadLine();
    }
}