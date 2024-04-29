using System;
using System.Collections.Generic;

public class Backpack
{
    public event EventHandler<ItemEventArgs> ItemAdded;
    public event EventHandler<ItemEventArgs> ItemRemoved;

    private string color;
    private string brand;
    private double weight;
    private double volume;
    private List<Item> contents;

    public Backpack(string color, string brand, double weight, double volume)
    {
        this.color = color;
        this.brand = brand;
        this.weight = weight;
        this.volume = volume;
        this.contents = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (GetFreeVolume() < item.Volume)
        {
            throw new InvalidOperationException("Ðþêçàê ïåðåïîâíåíèé!");
        }

        contents.Add(item);
        OnItemAdded(item);
    }

    public void RemoveItem(Item item)
    {
        contents.Remove(item);
        OnItemRemoved(item);
    }

    public void ViewContents()
    {
        Console.WriteLine("Âì³ñò ðþêçàêà:");
        foreach (var item in contents)
        {
            Console.WriteLine($"{item.Name}, Îá'ºì: {item.Volume}");
        }
    }

    public double GetFreeVolume()
    {
        double occupiedVolume = 0;
        foreach (var item in contents)
        {
            occupiedVolume += item.Volume;
        }
        return volume - occupiedVolume;
    }

    protected virtual void OnItemAdded(Item item)
    {
        ItemAdded?.Invoke(this, new ItemEventArgs(item));
    }

    protected virtual void OnItemRemoved(Item item)
    {
        ItemRemoved?.Invoke(this, new ItemEventArgs(item));
    }
}