namespace Encapsulacion;

public class ElectricStation
{
    private string name;
    private int charge;
    private string password;

    public ElectricStation()
    {
        name = "Electric Station";
        charge = 0;
        password = "1234";
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName, string inputPassword)
    {
        if (inputPassword != password)
        {
            Console.WriteLine("Error: Contraseña incorrecta.");
            return;
        }
        name = newName;
    }

    public int GetCharge()
    {
        return charge;
    }

    public void SetCharge(int newCharge)
    {
        if (newCharge < 0)
        {
            Console.WriteLine("Error: Thr charge cannot be negative.");
                               return;
        }
        if (newCharge > 100)
        {
            Console.WriteLine("Error: The charge cannot exceed 100.");
            return;
        }
        charge = newCharge;
    }
}