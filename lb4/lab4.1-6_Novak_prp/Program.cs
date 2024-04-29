using System;
using System.Collections.Generic;

abstract class Ship
{
    public abstract void Sail();
    public abstract void Stop();
}

class Steamship : Ship
{
    public override void Sail()
    {
        Console.WriteLine("Steamship sailed");
    }

    public override void Stop()
    {
        Console.WriteLine("Steamship stopped");
    }
}

class Sailboat : Ship
{
    public override void Sail()
    {
        Console.WriteLine("Sailboat sailed");
    }

    public override void Stop()
    {
        Console.WriteLine("Sailboat stopped");
    }
}

class Frigate : Ship
{
    public override void Sail()
    {
        Console.WriteLine("Frigate sailed");
    }

    public override void Stop()
    {
        Console.WriteLine("Frigate stopped");
    }
}

class Warship : Ship
{
    public override void Sail()
    {
        Console.WriteLine("Warship sailed");
    }

    public override void Stop()
    {
        Console.WriteLine("Warship stopped");
    }
}

class ShipCollection
{
    private List<Ship> ships = new List<Ship>();

    public void AddShip(Ship ship)
    {
        ships.Add(ship);
    }

    public void RemoveShip(Ship ship)
    {
        ships.Remove(ship);
    }

    public void CallVirtualMethod()
    {
        foreach (var ship in ships)
        {
            ship.Sail();
            ship.Stop();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShipCollection collection = new ShipCollection();

        Steamship steamship = new Steamship();
        Sailboat sailboat = new Sailboat();
        Frigate frigate = new Frigate();
        Warship warship = new Warship();

        collection.AddShip(steamship);
        collection.AddShip(sailboat);
        collection.AddShip(frigate);
        collection.AddShip(warship);

        collection.CallVirtualMethod();

        Console.ReadLine();
    }
}
