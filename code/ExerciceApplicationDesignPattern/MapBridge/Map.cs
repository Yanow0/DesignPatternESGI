using System;

public interface Map
{   
    void drawMap(int size, string shape);
    void addNpc(string npc);
    void removeNpc(string npc);
    void extendMap(int size);
    void shrinkMap(int size);
}
