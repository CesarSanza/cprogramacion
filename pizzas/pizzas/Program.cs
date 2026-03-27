namespace pizzas;

class Program
{
    static void Main(string[] args)
    {
        string[] ingredientesValidos = { "Queso", "Pepperoni", "Champiñones", "Aceitunas", "Tomate" };
        Loca miPizzeria = new Loca("mediana", ingredientesValidos);

        string opcion = "";

        while (opcion != "4")
        {
     
            Console.WriteLine("1. Pedir pizza sencilla");
            Console.WriteLine("2. Pedir pizza con ingredientes");
            Console.WriteLine("3. Pedir pizza con extra queso");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                miPizzeria.PedirPizza();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Ingredientes disponibles: Queso, Pepperoni, Champiñones, Aceitunas, Tomate");
                Console.Write("¿Cuántos ingredientes quieres agregar?: ");
                int cantidad = int.Parse(Console.ReadLine());

                string[] ingredientesPedidos = new string[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Ingrediente " + (i + 1) + ": ");
                    ingredientesPedidos[i] = Console.ReadLine();
                }

                miPizzeria.PedirPizza(ingredientesPedidos);
            }
            else if (opcion == "3")
            {
                Console.Write("¿Extra queso? (si/no): ");
                string entrada = Console.ReadLine();
                bool conExtraQueso = false;

                if (entrada == "si")
                {
                    conExtraQueso = true;
                }

                miPizzeria.PedirPizza(conExtraQueso);
            }
            else if (opcion == "4")
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