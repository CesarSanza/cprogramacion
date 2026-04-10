namespace Herencia;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Number of doors: ");
        int doors = int.Parse(Console.ReadLine());

        Car car = new Car(doors);

        Console.Write("How many times do you want to accelerate? ");
        int acelerar = int.Parse(Console.ReadLine());

        for (int i = 0; i < acelerar; i++)
        {
            car.Accelerate();
        }

        Console.Write("Do you want to use the brakes? (yes/no): ");
        bool brake = Console.ReadLine() == "yes";
        if (brake)
        {
            car.Break();
            Console.WriteLine("The car has slowed down.");
        }

        bool crashed = car.Crash();
        if (crashed)
            Console.WriteLine("The car crashed");
        else
            Console.WriteLine("The car is still running.");

        car.OpenTrunk();
    }
}