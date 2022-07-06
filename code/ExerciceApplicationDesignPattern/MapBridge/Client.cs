using System;


class Client
{
    static void Main(string[] args)
    {
        //Here we are implementing the builder pattern
        //We can create as many different Desert Maps as we need and they will all use the same interface.
        //You only need to pass the type of map you want to any desert map constructor to use its interface.
        DesertMapHardcore map1 = new DesertMapHardcore(new Map2D());
        map1.createMap();
        map1.destroyMap();
        Console.WriteLine("==========================================================");
        DesertMapEasy map2 = new DesertMapEasy(new Map3D());    
        map2.createMap();
        map2.destroyMap();
    }
}

