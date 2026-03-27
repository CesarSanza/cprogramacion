using NPCclase;

NPC npc = new NPC("Carlos", 25, "Humano");

Console.WriteLine("Escribe una accion para el NPC:");
string accion = Console.ReadLine();
npc.React(accion);

Console.WriteLine("Escribe otra accion:");
string accion2 = Console.ReadLine();
Console.WriteLine("Elige el mood (1=tranquilo, 2=serio, 3=molesto):");
int mood = int.Parse(Console.ReadLine());
npc.React(accion2, mood);

Console.WriteLine("Escribe otra accion:");
string accion3 = Console.ReadLine();
Console.WriteLine("¿Es tu amigo? (true/false):");
bool esamigo = bool.Parse(Console.ReadLine());
npc.React(accion3, esamigo);