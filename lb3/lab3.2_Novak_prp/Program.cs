using System;

class City
{
    private string cityName;
    private string countryName;
    private int population;
    private string postalCode;
    private string[] districts;

    private static int cityCount = 0;
    private static int totalPopulation = 0;

    public City(string cityName, string countryName, int population, string postalCode, string[] districts)
    {
        this.cityName = cityName;
        this.countryName = countryName;
        this.population = population;
        this.postalCode = postalCode;
        this.districts = districts;

        cityCount++;
        totalPopulation += population;
    }

    public void InputData()
    {
        Console.WriteLine("Введіть назву міста:");
        cityName = Console.ReadLine();

        Console.WriteLine("Введіть назву країни:");
        countryName = Console.ReadLine();

        Console.WriteLine("Введіть кількість жителів у місті:");
        population = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть поштовий індекс міста:");
        postalCode = Console.ReadLine();

        Console.WriteLine("Введіть назви районів міста (через кому):");
        string districtsInput = Console.ReadLine();
        districts = districtsInput.Split(',');

        cityCount++;
        totalPopulation += population;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Назва міста: {cityName}");
        Console.WriteLine($"Назва країни: {countryName}");
        Console.WriteLine($"Кількість жителів: {population}");
        Console.WriteLine($"Поштовий індекс: {postalCode}");
        Console.WriteLine("Назви районів міста:");
        foreach (var district in districts)
        {
            Console.WriteLine($"- {district}");
        }
    }

    public static int GetCityCount()
    {
        return cityCount;
    }

    public static int GetTotalPopulation()
    {
        return totalPopulation;
    }
}

class Program
{
    static void Main(string[] args)
    {
        City[] cities = new City[]
        {
            new City("Київ", "Україна", 2800000, "02000", new string[]{"Подільський", "Печерський", "Шевченківський"}),
            new City("Львів", "Україна", 720000, "79000", new string[]{"Шевченківський", "Галицький", "Залізничний"}),
            new City("Одеса", "Україна", 1000000, "65000", new string[]{"Приморський", "Малиновський", "Київський"}),
        };

        foreach (var city in cities)
        {
            city.DisplayData();
            Console.WriteLine();
        }

        Console.WriteLine($"Кількість створених міст: {City.GetCityCount()}");
        Console.WriteLine($"Загальна кількість жителів у містах: {City.GetTotalPopulation()}");
    }
}