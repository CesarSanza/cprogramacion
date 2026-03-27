namespace Musify;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nombre del álbum: ");
        string nombreAlbum = Console.ReadLine();

        Console.Write("¿Cuántas canciones tiene el álbum?: ");
        int cantidad = int.Parse(Console.ReadLine());

        string[] canciones = new string[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Canción " + (i + 1) + ": ");
            canciones[i] = Console.ReadLine();
        }

        Album miAlbum = new Album(nombreAlbum, canciones);

        Console.WriteLine("\nCanciones del álbum:");
        for (int i = 0; i < canciones.Length; i++)
        {
            Console.WriteLine((i + 1) + " - " + canciones[i]);
        }

        string opcion = "";

        while (opcion != "3")
        {
            Console.WriteLine("\n1. Reproducir canción por nombre");
            Console.WriteLine("2. Reproducir canción por índice");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Nombre de la canción: ");
                string nombre = Console.ReadLine();
                miAlbum.PlaySong(nombre);
            }
            else if (opcion == "2")
            {
                Console.Write("Índice de la canción: ");
                int indice = int.Parse(Console.ReadLine());
                miAlbum.PlaySong(indice -1);
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