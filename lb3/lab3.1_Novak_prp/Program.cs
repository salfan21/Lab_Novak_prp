using System;

class Record
{
    private int number;
    private string factory;
    public int plannedConsumption;
    public int actualConsumption;

    public Record(int number, string factory, int plannedConsumption, int actualConsumption)
    {
        this.number = number;
        this.factory = factory;
        this.plannedConsumption = plannedConsumption;
        this.actualConsumption = actualConsumption;
    }

    public int CalculateDeviation()
    {
        return actualConsumption - plannedConsumption;
    }

    public double CalculatePercentageDeviation()
    {
        return CalculateDeviation() * 100.0 / plannedConsumption;
    }

    public override string ToString()
    {
        return $"| {number,-5} | {factory,-10} | {plannedConsumption,-20} | {actualConsumption,-25} | {CalculateDeviation(),-10} | {CalculatePercentageDeviation(),-10:F2}% |";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Record[] records = new Record[]
        {
            new Record(1, "Завод1", 1000, 950),
            new Record(2, "Завод2", 1500, 1400),
        };

        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| № з/п |   Завод   | Планове споживання | Фактичне споживання | Відхилення | Відсоток відхилення |");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        foreach (var record in records)
        {
            Console.WriteLine(record);
        }

        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        int totalPlanned = 0;
        int totalActual = 0;
        foreach (var record in records)
        {
            totalPlanned += record.plannedConsumption;
            totalActual += record.actualConsumption;
        }
        Console.WriteLine($"| Разом |           | {totalPlanned,-20} | {totalActual,-25} | {totalActual - totalPlanned,-10} |");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
    }
}
