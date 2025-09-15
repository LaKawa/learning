// See https://aka.ms/new-console-template for more information

using CSharpInANutshell.Basics;

Inheritance inheritance = new();
inheritance.Upcast(inheritance.Stock, inheritance.House);
inheritance.Downcast(new Asset());
