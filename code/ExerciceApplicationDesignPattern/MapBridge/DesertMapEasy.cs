using System;

public class DesertMapEasy : DesertMap
{
  public DesertMapEasy(Map map) : base(map){}

  protected override void setBossLevel()
  {
    bossLevel = 2;
    Console.WriteLine("Boss level set to " + bossLevel);
  }
}
