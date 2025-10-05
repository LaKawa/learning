// See https://aka.ms/new-console-template for more information

using CSharpInANutshell.Basics;
using CSharpInANutshell.Experiments.EnumUsage;
using CSharpInANutshell.Experiments.InterfaceOverriding;
using InterfaceOverridingCaller = CSharpInANutshell.Experiments.InterfaceOverriding.Caller;

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

// can set required members via {} or parameterless constructor
//InterfaceOverridingCaller caller = new();
var caller2 = new InterfaceOverridingCaller{};
caller2.PrintExample();

var side = BorderSide.Left;
var alignment = (Alignment)side;

var permissions = FilePermissions.Write | FilePermissions.Delete;
Console.WriteLine(permissions.ToString());