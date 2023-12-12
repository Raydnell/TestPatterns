using CsharpPatterns.Patterns;
using CsharpPatterns.Patterns.AbstractFabric;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractFabricDungeons fabric = new UnderwaterDungeonsFabric();
        
        ActionWindow actionWindow = new ActionWindow(fabric);
        
        actionWindow.WhatFabricDungeonsCreated();
        
        Console.ReadKey();
    }
}
