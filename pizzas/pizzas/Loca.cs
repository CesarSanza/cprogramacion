namespace pizzas;

public class Loca
{
    private string tamaño;
    private string[] ingredientes;
    private bool extraQueso;

    public Loca(string tamaño, string[] ingredientes)
    {
        this.tamaño = tamaño;
        this.ingredientes = ingredientes;
        this.extraQueso = false;
    }

    public string GetDescripcion()
    {
        return tamaño;
    }

    public void AgregarIngrediente(string ingrediente)
    {
        for (int i = 0; i < ingredientes.Length; i++)
        {
            if (ingredientes[i] == ingrediente)
            {
                Console.WriteLine("¡La pizza ha sido entregada!");
                return;
            }
        }
        Console.WriteLine("Lo sentimos, el ingrediente " + ingrediente + " no es válido.");
    }

    public void PedirPizza()
    {
        Console.WriteLine("¡Una pizza sencilla ha sido entregada!");
    }

    public void PedirPizza(string[] ingredientesPedidos)
    {
        for (int i = 0; i < ingredientesPedidos.Length; i++)
        {
            AgregarIngrediente(ingredientesPedidos[i]);
        }
    }

    public void PedirPizza(bool extraQueso)
    {
        if (extraQueso == true)
        {
            Console.WriteLine("¡Una pizza sencilla con queso extra ha sido entregada!");
        }
        else
        {
            Console.WriteLine("¡Una pizza sencilla ha sido entregada!");
        }
    }
}