namespace Ghost;

public class character
{
    protected string name;

    public character()
    {
        Introduce();
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, world!");
    }
}

public class Gost:character
{
    public Gost()
    {
        Introduce();
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("Dont you dare screaming!");
    }
}