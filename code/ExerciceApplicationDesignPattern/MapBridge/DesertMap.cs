using System; 

public abstract class DesertMap
{
    protected Map map;
    protected int bossLevel;

    public DesertMap(Map map){
        this.map = map;
    }

    public void createMap(){
        map.drawMap(100, "Circle");
        map.addNpc("Boss");
        this.setBossLevel();
        startSandstorm();
        Console.WriteLine("Desert map created");
    }

    public void destroyMap(){
        map.removeNpc("boss");
        endSandstorm();
        Console.WriteLine("Desert map destroyed");
    }

    public void startSandstorm(){
        map.shrinkMap(10);
        Console.WriteLine("Sandstorm started");
    }

    public void endSandstorm(){
        map.extendMap(10);
        Console.WriteLine("Sandstorm ended");
    }

    protected abstract void setBossLevel();

}