using TreeNamespace;

Tree tree = new Tree();

Console.WriteLine("Commands: bloom | dry | exit");
Console.WriteLine("Size: " + tree.size + " | Foliage: " + tree.foliage);


while (true)
{
    Console.Write("Enter command: ");
    string input = Console.ReadLine().Trim().ToLower();

    if (input == "exit")
    {
        Console.WriteLine("Exiting...");
        break;
    }
    else if (input == "bloom")
    {
        tree.Bloom();
    }
    else if (input == "dry")
    {
        tree.Dry();
    }
    else
    {
        Console.WriteLine("Unknown command. Use: bloom | dry | exit");
    }

    Console.WriteLine("Size: " + tree.size + " | Foliage: " + tree.foliage);
}