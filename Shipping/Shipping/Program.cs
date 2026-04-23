using System;

namespace ShipmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("¿Qué tipo de envío deseas?");
            Console.WriteLine("1. Standard");
            Console.WriteLine("2. Express");
            
            string opcion = Console.ReadLine();

          
            Console.Write("\nIngresa el peso (kg): ");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("Ingresa la distancia (km): ");
            float distance = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el impuesto de aduana (ej. 0.2 para 20%): ");
            float aduana = float.Parse(Console.ReadLine());

            Console.WriteLine(" Resultados ");

            if (opcion == "1")
            {
                Console.Write("Ingresa los días en almacén: ");
                int days = int.Parse(Console.ReadLine());

                StandardShipment standard = new StandardShipment(weight, distance);
                standard.SetDaysInWarehouse(days);

                Console.WriteLine(" Envío Standard");
                Console.WriteLine("Costo base:        " + standard.CalculateCost());
                Console.WriteLine("Costo con aduana:  " + standard.CalculateCost(aduana));
                Console.WriteLine("Costo de almacén:  " + standard.CalculateWarehouseCost());
            }
            else if (opcion == "2")
            {
                ExpressShipment express = new ExpressShipment(weight, distance);

                Console.WriteLine("Envío Express");
                Console.WriteLine("Costo base:        " + express.CalculateCost());
                Console.WriteLine("Costo con aduana:  " + express.CalculateCost(aduana));
                express.PrioritizeShipment();
            }
            else
            {
                Console.WriteLine("Opción no valida.");
            }
        }
    }
}