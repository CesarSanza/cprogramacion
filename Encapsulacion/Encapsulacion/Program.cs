using Encapsulacion;

ElectricStation station = new ElectricStation();

Console.WriteLine(" Electric Station Manager ");
Console.WriteLine("Commands: setcharge | setname | getname | getcharge | exit");

while (true)
{
    Console.Write("Enter command: ");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        Console.WriteLine("Exiting");
        break;
    }
    else if (input == "setcharge")
    {
        Console.Write("Enter charge value: ");
        string chargeInput = Console.ReadLine();

        if (int.TryParse(chargeInput, out int newCharge))
        {
            station.SetCharge(newCharge);
        }
        else
        {
            Console.WriteLine("Error: Ingresa un número válido.");
        }
    }
    else if (input == "setname")
    {
        Console.Write("Enter new name: ");
        string newName = Console.ReadLine();

        Console.Write("Enter password: ");
        string pass = Console.ReadLine();

        station.SetName(newName, pass);
    }
    else if (input == "getname")
    {
        Console.WriteLine("Station name: " + station.GetName());
    }
    else if (input == "getcharge")
    {
        Console.WriteLine("Current charge: " + station.GetCharge());
    }
    else
    {
        Console.WriteLine("Unknown command. Use: setcharge | setname | getname | getcharge | exit");
    }
    
}