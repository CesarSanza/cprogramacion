namespace LabHerencia2;

class Survivor
{
    protected string name;
    protected int health;

    public Survivor(string name, int health)
    {
        this.name   = name;
        this.health = health;
    }

    public string GetName()
    {
        return name;
    }

    public int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(1, 21);
    }

    public void GetStatus()
    {
        Console.WriteLine($"[Survivor] {name} | HP: {health}");
    }
}

class Citizen : Survivor
{
    public Citizen(string name, int health)
        : base(name, health) { }

    public int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} Attack the zombie. Total Damage: {damage}");
        return damage;
    }

    public bool Hide()
    {
        Random rnd = new Random();
        bool escondido = rnd.Next(0, 2) == 1;
        if (escondido)
            Console.WriteLine($"{name} hide inmediately.");
        else
            Console.WriteLine($"{name} try to hide but its too late!");
        return escondido;
    }

    public void GetStatus()
    {
        Console.WriteLine($"[Citizen]  {name} | HP: {health}");
    }
}

class Soldier : Survivor
{
    private int ammo;

    public Soldier(string name, int health, int ammo)
        : base(name, health)
    {
        this.ammo = ammo;
    }

    public int Defend()
    {
        if (ammo > 0)
        {
            ammo--;
            int damage = GetDamage();
            Console.WriteLine($"{name} shoot the zombie. total damage: {damage} |remaining bullets: {ammo}");
            return damage;
        }
        else
        {
            Console.WriteLine($"{name} no more bullets. Reload first!");
            return 0;
        }
    }

    public void Reload()
    {
        ammo += 10;
        Console.WriteLine($"{name} Reloading the gun: {ammo}");
    }

    public void GetStatus()
    {
        Console.WriteLine($"[Soldier]  {name} | HP: {health} | Ammo: {ammo}");
    }
}

class Engineer : Survivor
{
    private string trapName;

    public Engineer(string name, int health, string trapName)
        : base(name, health)
    {
        this.trapName = trapName;
    }

    public int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} activate the tramp{trapName}'. Total Damage: {damage}");
        return damage;
    }

    public void ResetTrap()
    {
        Console.WriteLine($"{name} restart '{trapName}'. ready to use it again.");
    }

    public void GetStatus()
    {
        Console.WriteLine($"[Engineer] {name} | HealthPoints: {health} | Tramp: {trapName}");
    }
}