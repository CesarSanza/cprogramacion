namespace Herencia;

public class Vehicle
{
    
    protected string brand;
    protected int speed;

    public Vehicle()
    {
        this.brand = "Aston Martin";
        this.speed = 0;
    }
    
    public void Accelerate()
    {
        speed += 40;
        Console.WriteLine($"New speed {speed}");
    }

    public void Break()
    {
        speed -= 20;
    }

    public bool Crash()
    {
        if (speed > 100)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(0, 2);
            return randNum == 1;
        }
        return false;
    }
}

class Car : Vehicle
{
    private int doorsNum;

    public Car(int doorsNum)
        : base()
    {
        this.doorsNum = doorsNum;
    }

    public void OpenTrunk()
    {
        if (doorsNum % 2 != 0)
            Console.WriteLine("The trunk is open");
        else
            Console.WriteLine("This car has no trunk");
    }
}
