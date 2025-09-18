// See https://aka.ms/new-console-template for more information

using CSharpInANutshell.Basics;

Inheritance inheritance = new();
inheritance.Upcast(inheritance.Stock, inheritance.House);
inheritance.Downcast(new Asset());
Asset asset = new Asset() {Name = "My asset"};
asset.Print();
Stock stock = new Stock();
Asset stockAsset = stock;
if(stockAsset is Stock)
    stockAsset.Print();
House house = new House() { Name = "My House" };
house.Print();
Asset houseAsset = house;
if(houseAsset is House)
    houseAsset.Print();

var copiedAsset = stockAsset.Copy();
Console.WriteLine(copiedAsset.GetType().Name);
var copiedHouse = houseAsset.Copy();
Console.WriteLine(copiedHouse.GetType().Name);
if (copiedHouse is House)
{
    Console.WriteLine(((House)copiedHouse).GetType().Name);
}


