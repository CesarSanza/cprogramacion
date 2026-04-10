namespace LabHerencia2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Citizen's name: ");
        string nombreCitizen = Console.ReadLine();
        Console.Write("HealthPoits of the Citizen: ");
        int hpCitizen = int.Parse(Console.ReadLine());

        Console.Write("Soldier's name: ");
        string nombreSoldier = Console.ReadLine();
        Console.Write("HealthPoits of the Soldier: ");
        int hpSoldier = int.Parse(Console.ReadLine());
        Console.Write("Soldier's bulllets: ");
        int ammo = int.Parse(Console.ReadLine());

        Console.Write("Engineer's name: ");
        string nombreEngineer = Console.ReadLine();
        Console.Write("HealthPoits of the Engineer: ");
        int hpEngineer = int.Parse(Console.ReadLine());
        Console.Write("Tramp's name: ");
        string trampa = Console.ReadLine();

        Console.WriteLine();

        Citizen  citizen  = new Citizen(nombreCitizen, hpCitizen);
        Soldier  soldier  = new Soldier(nombreSoldier, hpSoldier, ammo);
        Engineer engineer = new Engineer(nombreEngineer, hpEngineer, trampa);

        citizen.GetStatus();
        soldier.GetStatus();
        engineer.GetStatus();

        Console.WriteLine();

        int danoCitizen = citizen.Defend();

        int danoSoldier = soldier.Defend();

        soldier.Reload();

        bool escondido = citizen.Hide();
        if (escondido)
            Console.WriteLine($"{citizen.GetName()} hide in time!");
        else
            Console.WriteLine($"{citizen.GetName()} could not found a place to hide...");

        int danoEngineer = engineer.Defend();

        engineer.ResetTrap();

        Console.WriteLine("\nFinal status");
        citizen.GetStatus();
        soldier.GetStatus();
        engineer.GetStatus();
    }
}