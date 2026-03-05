namespace TreeNamespace;

public class Tree
{
    public int size;
    public string foliage;
    public string[] foliageLevels = { "Too much", "Not much", "None" };

    public Tree()
    {
        size = 100;
        foliage = "Too much";
    }

    public void Bloom()
    {
        size += 10;
        Console.WriteLine("The new size is " + size + ".");
    }

    public void Dry()
    {
        if (foliage == "Too much")
        {
            foliage = "Not much";
        }
        else if (foliage == "Not much")
        {
            foliage = "None";
        }

        Console.WriteLine("The new foliage is " + foliage);
    }
}