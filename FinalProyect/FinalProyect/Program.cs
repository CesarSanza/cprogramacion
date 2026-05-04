namespace FinalProyect;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        MostrarBienvenida();

        CajaFuerte caja = new CajaFuerte();
        bool victoria = false;

        while (!caja.EstaCompleta) 
        {
            Cerradura cerraduraActiva = caja.CerraduraActiva;

            Console.Clear();
            MostrarEncabezado(caja.NumCerraduraActual, caja.TotalCerraduras);
            Console.WriteLine(cerraduraActiva.ObtenerDescripcion());
            Console.WriteLine($"\n  Intentos realizados: {cerraduraActiva.Intentos}");
            Console.WriteLine();

            bool cerraduraResuelta = false;
            while (!cerraduraResuelta)
            {
                Console.WriteLine("  ┌─────────────────────────────────┐");
                Console.WriteLine("  │  [1] Ingresar número            │");
                Console.WriteLine("  │  [2] Pedir pista                │");
                Console.WriteLine("  │  [3] Fuerza bruta (trampa)      │");
                Console.WriteLine("  │  [4] Ver historial              │");
                Console.WriteLine("  │  [5] Salir                      │");
                Console.WriteLine("  └─────────────────────────────────┘");
                Console.Write("  → Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("  → Ingresa tu número (1-50): ");
                        string entrada = Console.ReadLine();

                        bool resultado = cerraduraActiva.Intentar(entrada);
                        int numeroInt = int.TryParse(entrada, out int n) ? n : -1;
                        string calor = numeroInt > 0 ? cerraduraActiva.HintCalor(numeroInt) : "N/A";

                        caja.RegistrarIntento(cerraduraActiva.Nombre, numeroInt, resultado, calor);

                        if (resultado)
                        {
                            MostrarExito(cerraduraActiva.Nombre);
                            cerraduraResuelta = true;
                            caja.RegistrarEvento($"Cerradura '{cerraduraActiva.Nombre}' ABIERTA.");
                        }
                        else
                        {
                            Console.WriteLine($"  ✗ Incorrecto. {calor}");
                        }
                        break;

                    case "2":
                        string pista = cerraduraActiva.SolicitarPista();
                        Console.WriteLine(pista);
                        caja.RegistrarEvento($"Pista solicitada para '{cerraduraActiva.Nombre}'.");
                        PausarConsola();
                        break;

                    case "3":
                        Console.Write("   La fuerza bruta registra todos los intentos. ¿Confirmar? (s/n): ");
                        if (Console.ReadLine()?.ToLower() == "s" )
                        {
                            cerraduraActiva.Intentar(true);
                            cerraduraResuelta = cerraduraActiva.EstaAbierta;
                            caja.RegistrarEvento($"Fuerza bruta usada en '{cerraduraActiva.Nombre}'.");
                        }
                        break;

                    case "4":
                        caja.MostrarHistorial();
                        PausarConsola();
                        break;

                    case "5":
                        Console.WriteLine("\n  Sesión terminada. ¡Hasta la próxima, Feynman!");
                        caja.GuardarResumen(false);
                        return;

                    default:
                        Console.WriteLine("  [!] Opción no válida.");
                        break;
                }
            }

            caja.AvanzarCerradura();

            if (!caja.EstaCompleta)
            {
                Console.WriteLine("\n  ¡Cerradura superada! Preparando la siguiente...");
                PausarConsola();
            }
            else
            {
                victoria = true;
            }
        }

        if (victoria)
        {
            MostrarVictoria();
            caja.GuardarResumen(true);
        }
    }
// Hasta aqui de Cesar
    static void MostrarBienvenida()
    {
        Console.Clear();
        Console.WriteLine(@"
  ╔══════════════════════════════════════════════════════════╗
  ║                                                          ║
  ║         SAFECRACKER MEETS SAFECRACKER                    ║
  ║                                                          ║
  ║    Inspirado en Richard Feynman, Los Alamos, 1943        ║
  ║    'No es suerte. Es entender cómo piensan.'             ║
  ║                                                          ║
  ╚══════════════════════════════════════════════════════════╝

  Deberás abrir una caja fuerte con 3 cerraduras.
  Cada cerradura sigue un patrón... ¡descúbrelo!
");
        PausarConsola();
    }

    static void MostrarEncabezado(int actual, int total)
    {
        Console.WriteLine($"\n CERRADURA {actual} de {total}");
        Console.WriteLine("  " + new string('─', 55));
    }
    
    static void MostrarExito(string nombre)
    {
        Console.WriteLine($@"
  ╔══════════════════════════════════════════╗
  ║       ¡CERRADURA ABIERTA!                ║
  ║  '{nombre}' ha sido descifrada.
  ╚══════════════════════════════════════════╝");
        PausarConsola();
    }

    static void MostrarVictoria()
    {
        Console.Clear();
        Console.WriteLine(@"
  ╔══════════════════════════════════════════════════════════╗
  ║                                                          ║
  ║          ¡CAJA FUERTE ABIERTA!                           ║
  ║                                                          ║
  ║    Lo lograste. Como Feynman, no fue suerte:             ║
  ║    fue entender cómo piensan las personas.               ║
  ║                                                          ║
  ║    Tu sesión ha sido guardada en:                        ║
  ║    → sesion_safecracker.txt                              ║
  ║                                                          ║
  ╚══════════════════════════════════════════════════════════╝
");
    }

    static void PausarConsola()
    {
        Console.Write("\n  [Presiona ENTER para continuar...]");
        Console.ReadLine();
    }
}
