namespace NPCclase;

public class NPC
{
    private string name;
    private float age;
    public string race;

    public NPC(string name, float age, string race)
    {
        this.name = name;
        this.age = age;
        this.race = race;
    }

    public void React(string action)
    {
        Console.WriteLine(name + " recibe \"" + action + "\" y hace una mueca confundida.");
    }

    public void React(string action, int mood)
    {
        string reaction;
        switch (mood)
        {
            case 1:
                reaction = "tranquilamente.";
                break;
            case 2:
                reaction = "seri@.";
                break;
            case 3:
                reaction = "enojad@!";
                break;
            default:
                reaction = "de forma inesperada.";
                break;
        }
        Console.WriteLine(name + " reacciona " + reaction);
    }

    public void React(string action, bool isFriend)
    {
        string reaction = isFriend ? "con un abrazo ." : " seri@.";
        Console.WriteLine(name + " recibe \"" + action + "\" y responde " + reaction);
    }
}