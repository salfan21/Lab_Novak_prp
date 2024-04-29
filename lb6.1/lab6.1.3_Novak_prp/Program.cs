using System;

class Program
{
    static void Main(string[] args)
    {
        Backpack backpack = new Backpack("Чорний", "Nike", 1.5, 20);

        backpack.ItemAdded += Backpack_ItemAdded;
        backpack.ItemRemoved += Backpack_ItemRemoved;

        backpack.AddItem(new Item { Name = "Книга", Volume = 5 });
        backpack.AddItem(new Item { Name = "Ланчбокс", Volume = 3 });
        backpack.AddItem(new Item { Name = "Вода", Volume = 2 });

        backpack.ViewContents();

        backpack.RemoveItem(new Item { Name = "Ланчбокс", Volume = 3 });

        backpack.ViewContents();
    }

    private static void Backpack_ItemAdded(object sender, ItemEventArgs e)
    {
        Console.WriteLine($"Предмет {e.Item.Name} додано в рюкзак");
    }

    private static void Backpack_ItemRemoved(object sender, ItemEventArgs e)
    {
        Console.WriteLine($"Предмет {e.Item.Name} видалено з рюкзака");
    }
}
