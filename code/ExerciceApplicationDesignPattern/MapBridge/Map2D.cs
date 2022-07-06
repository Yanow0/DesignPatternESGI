using System;

public class Map2D : Map
{
    public void drawMap(int size, string shape)
    {
        Console.WriteLine(shape + " 2D Map with each side being " + size + "units long");
    }

    public void addNpc(string npc)
    {
        Console.WriteLine("Npc " + npc + " added to the 2D map");
    }

    public void removeNpc(string npc)
    {
        Console.WriteLine("Npc " + npc + " removed from the 2D map");
    }

    public void extendMap(int size)
    {
        Console.WriteLine("2D map extended by " + size + " units");
    }

    public void shrinkMap(int size)
    {
        Console.WriteLine("2D map shrunk by " + size + " units");
    }
  
}
