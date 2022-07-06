using System;

public class Map3D : Map
{
    public void drawMap(int size, string shape)
    {
        Console.WriteLine(shape + " 3D Map with each edge being " + size + "units long");
    }

    public void addNpc(string npc)
    {
        Console.WriteLine("Npc " + npc + " added to the 3D map");
    }

    public void removeNpc(string npc)
    {
        Console.WriteLine("Npc " + npc + " removed from the 3D map");
    }

    public void extendMap(int size)
    {
        Console.WriteLine("3D map extended by " + size + " units");
    }

    public void shrinkMap(int size)
    {
        Console.WriteLine("3D map shrunk by " + size + " units");
    }
  
}
