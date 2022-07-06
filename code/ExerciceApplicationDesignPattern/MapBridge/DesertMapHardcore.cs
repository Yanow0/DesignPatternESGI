using System;

public class DesertMapHardcore : DesertMap
{
  public DesertMapHardcore(Map map) : base(map){}

  protected override void setBossLevel()
  {
    bossLevel = 8;
    Console.WriteLine("Boss level set to " + bossLevel);
  }
}
