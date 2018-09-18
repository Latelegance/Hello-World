using System;
using System.Collections.Generic;

public class Vegetable
{
    public Vegetable(string name) => Name = name;

    public string Name { get; }

    public override string ToString() => Name;
}
public class Program
{
    static void interpolation()
    {
        Console.WriteLine("\n创建内插字符串：");
        var name = "<name>";
        Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
    }
    public enum Unit { item, kilogram, gram, dozen };

    public static void format()
    {
        Console.WriteLine("\n包含不同的数据类型：");
        var item = new Vegetable("eggplant");
        var date = DateTime.Now;
        var price = 1.99m;
        var unit = Unit.item;
        Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");

        Console.WriteLine("\n控制内插表达式的格式：");
        Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}.");
    }
        public static void Main()
    {
        Console.WriteLine("\n控制内插表达式的字段宽度和对齐方式：");

        var titles = new Dictionary<string, string>()
        {
            ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
            ["London, Jack"] = "Call of the Wild, The",
            ["Shakespeare, William"] = "Tempest, The"
        };

        Console.WriteLine("Author and Title List");
        Console.WriteLine();
        Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
        foreach (var title in titles)
            Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");

        Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
    }

}
