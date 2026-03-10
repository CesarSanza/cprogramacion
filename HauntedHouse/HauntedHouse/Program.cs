namespace HauntedHouse;

class Program
{
    static void Main(string[] args)
    {
        Level level1 = new Level("The Haunted Mansion", 11803, "Low level");
        level1.ShowInfo();
        level1.SpookVisitors();

        Level level2 = new Level("The Dark House", 11803, "Medium level");
        level2.ShowInfo();
        level2.SpookVisitors();

        Level level3 = new Level("The Cursed Castle", 11803, "High level");
        level3.ShowInfo();
        level3.SpookVisitors();

        Level level4 = new Level("The Death House", 11803, "Extreme");
        level4.ShowInfo();
        level4.SpookVisitors();
    }
}