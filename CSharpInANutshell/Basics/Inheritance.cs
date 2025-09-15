using System.Globalization;

namespace CSharpInANutshell.Basics;

public class Inheritance
{
    public Stock Stock = new Stock { Name = "ADA", SharesOwned = 10_000 };
    public House House = new House { Name = "My House in the middle of the street", Mortgage = 100_000 };

    public void PrintAssets(Stock stock)
    {
        Console.WriteLine($"Name = {stock.Name}");
        Console.WriteLine($"Shares owned: {stock.SharesOwned}");
    }
    public void PrintAssets(House house)
    {
        Console.WriteLine($"Name = {house.Name}");
        Console.WriteLine($"Mortgage = {house.Mortgage}");
    }
    // polymorphism: can use subclasses to be treated like an asset by this method
    public void PrintAssets(Asset asset)
    {
        Console.WriteLine($"It's a {asset.GetType().Name}, name = {asset.Name}");
    }

    public void PrintAssets(object asset)
    {
    }

    public void Upcast(Stock stock, House house)
    {
        Console.WriteLine("Upcasting a subclass happens implicitly, it creates a reference to the original object.");
        Asset stockAsset = stock;
        Asset houseAsset = house;
        PrintAssets(stockAsset);
        PrintAssets(houseAsset);
        Console.WriteLine($"stockAsset == stock? - {stockAsset == stock}");
        Console.WriteLine($"houseAsset == house? - {houseAsset == house}");
        Console.WriteLine($"stockAsset == house? - {stockAsset == house}");
    }

    public void Downcast(Asset asset)
    {
        // may use is-operator with type pattern to check if downcast will work
        if (asset is Stock)
        {
            
            Console.WriteLine($"Asset is a stock! Shares owned: {((Stock)asset).SharesOwned}");
        }
        // may introduce a variable in the type pattern, it's available for immediate consumption and stays in scope within if/else blocks
        else if (asset is House house && house.Name != "FakeHouse") 
        {
            Console.WriteLine($"Asset is a house! Mortgage: {house.Mortgage}");
        }
        else
        {
            // house is still accessible here, but might be uninitialized
            // house.Name = "FakeHouse";
            Console.WriteLine($"Asset is not a stock or house! {asset.GetType().Name}");
        }
    }
}

public class Asset
{
    public string Name;
    public virtual void Print() => Console.WriteLine($"Asset Print was called! Name = {Name}");

    public virtual Asset Copy() => new Asset { Name = Name };
}

public class Stock : Asset
{
    public long SharesOwned;

    // this allows for polymorphism - if a Stock is cast to an Asset and Print() is called,
    // it will call the override on the Stock type
    public override void Print() =>
        Console.WriteLine($"Overriden Stock Print! Name = {Name}, Shares owned: {SharesOwned}");

    // since C#9 we can use covariant return types
    // => derived classes can use a more derived return type than their base class
    public override Stock Copy() => new Stock { Name = Name, SharesOwned = SharesOwned };
}

public class House : Asset
{
    // no override for Print() specified, uses the Asset Print() method
    public decimal Mortgage;
    
    // before C#9, override had to return the same type as base class
    // => explicit downcast to use as House was mandatory
    public override Asset Copy() => new House { Name = Name, Mortgage = Mortgage };
}