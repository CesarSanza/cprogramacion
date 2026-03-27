namespace Drone;

class Program
{
    static void Main(string[] args)
    {
        DRONE miDrone = new DRONE();
        string opcion = "";

        while (opcion != "3")
        {
            Console.WriteLine("1. Poner batería");
            Console.WriteLine("2. Cambiar altura");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Nueva batería: ");
                int bateria = int.Parse(Console.ReadLine());
                miDrone.SetBattery(bateria);
                Console.WriteLine("Batería establecida en: " + miDrone.GetBattery());
            }
            else if (opcion == "2")
            {
                Console.Write("Nueva altura: ");
                int altura = int.Parse(Console.ReadLine());
                miDrone.SetHeight(altura);

                if (miDrone.GetDroneOn())
                {
                    Console.WriteLine("Altura cambiada a: " + miDrone.GetHeight());
                    Console.WriteLine("La batería bajó a: " + miDrone.GetBattery());
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }
        }
    }
}