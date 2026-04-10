using LabHerencia;

Band band = new Band("Mario y su chaval", "Mexico", "Cumbias");

Dj dj = new Dj("Malilla", "Wine & Bread", "Heavy Metal", "Dolby Area", 500);
string escenario = band.GetStageSize();
Console.WriteLine($"Hey, we need a {escenario} stage for Mario y su chaval!");

band.Introduce();

bool encore = band.PlayEncore();
if (encore)
    Console.WriteLine("The crowd goes absolutely crazy! They're coming back for more!\n");
else
    Console.WriteLine("Oh, it ended too soon.\n");

dj.Introduce();

int duracion = dj.MixTrack();
Console.WriteLine($"Malilla's track is {duracion} seconds long.");

int energia = dj.GetEnergyLevel();

if (energia <= 3)
    Console.WriteLine("Such a chill vibe... perfect for a slow night.");
else if (energia <= 6)
    Console.WriteLine("Can you feel the vibes of this song?");
else if (energia <= 8)
    Console.WriteLine("The energy is through the roof! Everyone's dancing!");
else
    Console.WriteLine("This is awesome! The whole crowd is losing their minds!");