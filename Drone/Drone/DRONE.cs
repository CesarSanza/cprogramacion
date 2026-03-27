
namespace Drone;

public class DRONE
{
    private int battery = 100;
    private int height = 0;
    private bool droneOn = true;

    public int GetBattery()
    {
        return battery;
    }

    public int GetHeight()
    {
        return height;
    }

    public bool GetDroneOn()
    {
        return droneOn;
    }

    public void Fall()
    {
        droneOn = false;
        height = 0;
        Console.WriteLine("El drone se ha estrellado");
    }

    public void ResetHeight()
    {
        height = 0;
    }

    public void SetBattery(int newBattery)
    {
        if (newBattery > 100)
        {
            Console.WriteLine("No puedes tener bateria mayor a 100");
        }
        else
        {
            battery = newBattery;
        }
    }

    public void SetHeight(int newHeight)
    {
        if (droneOn == false)
        {
            Console.WriteLine("El drone está apagado, no puede volar.");
            return;
        }

        if (newHeight < 0)
        {
            newHeight = 0;
        }

        if (battery < 40)
        {
            Fall();
            return;
        }

        battery = battery - 40;
        height = newHeight;

        if (battery <= 0)
        {
            Fall();
        }
    }
}