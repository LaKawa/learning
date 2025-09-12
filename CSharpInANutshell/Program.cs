// See https://aka.ms/new-console-template for more information

using CSharpInANutshell.Basics;

var myTestType = new CreatingTypes(42, true, "potato");

var (a, b, c) = myTestType;
Console.WriteLine(b);
Console.WriteLine(a);

var myTestType2 = new CreatingTypes (42){ Name = "hello" };
