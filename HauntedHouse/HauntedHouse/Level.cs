namespace HauntedHouse;

public class Level
{
    private string name;
    private int address;
    private string horrorLevel;

    public Level(string name, int address, string horrorLevel)
    {
        this.name = name;
        this.address = address;
        this.horrorLevel = horrorLevel;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Horror Level: {horrorLevel}");
    }

    public void SpookVisitors()
    {
        Console.WriteLine("Are you ready?");    
        Console.ReadLine();

        switch (horrorLevel)
        {
            case "Low level":
                Console.WriteLine("level 1");
                Console.WriteLine("The door is closing itself");
                Console.WriteLine("EVERYONE´S SHAKING");
                break;
            case "Medium level":
                Console.WriteLine("level 2");
                Console.WriteLine("Your eyes started seen souls");
                Console.WriteLine("Someone is wispering your name");
                break;
            case "High level":
                Console.WriteLine("level 3");
                Console.WriteLine("You start feeling a hand under your knee");
                Console.WriteLine("You passed Out");
                break;
            case "Extreme":
                Console.WriteLine("level 4");
                Console.WriteLine("There is not way out");
                Console.WriteLine("You´re DEAD");
                break; 
        }
    }
}