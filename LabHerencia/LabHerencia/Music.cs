namespace LabHerencia;
class Artist
{
    protected string name;
    protected string country;
    protected string genre;
    
    public Artist(string name, string country, string genre)
    {
        this.name    = name;
        this.country = country;
        this.genre   = genre;
    }

    public void Perform()
    {
        Console.WriteLine($"The public is going wild. {name} is playing awesome!");
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi! We are {name} from {country}. We play {genre} music.");
    }
}

class Band : Artist
{
    public int numOfMembers;

    public Band(string name, string country, string genre)
        : base(name, country, genre)
    {
        this.numOfMembers = 5;
    }

    public string GetStageSize()
    {
        return "Medium";
    }

    public bool PlayEncore()
    {
        Console.Write("Does the crowd want an encore? (yes/no): ");
        bool encore = Console.ReadLine() == "yes";
        return encore;
    }
}

class Dj : Artist
{
    public string software;
    private int trackDuration;
    public void Introduce()
    {
        Console.WriteLine($"Hi! I'm {name} from {country}. I play {genre} music.");
    }
    public Dj(string name, string country, string genre, string software, int trackDuration)
        : base(name, country, genre)
    {
        this.software      = software;
        this.trackDuration = trackDuration;
    }

    public int MixTrack()
    {
        return trackDuration;
    }

    public int GetEnergyLevel()
    {
        int energia = 0;
        bool valido = false;

        while (!valido)
        {
            Console.Write($"Enter the energy level of {name}'s song (1-10): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out energia) && energia >= 1 && energia <= 10)
                valido = true;
            else
                Console.WriteLine("Please enter a valid number between 1 and 10.");
        }

        return energia;
    }
}