using BankLab1;

ClassB cuenta = new ClassB("César", 1000);

int opcion = 0;

while (opcion != 4)
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Mostrar saldo");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Retirar");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine(cuenta.ShowBalance());
    }
    else if (opcion == 2)
    {
        Console.Write("¿Cuánto deseas depositar? ");
        float amount = float.Parse(Console.ReadLine());
        cuenta.Deposit(amount);
    }
    else if (opcion == 3)
    {
        Console.Write("¿Cuánto deseas retirar? ");
        float amount = float.Parse(Console.ReadLine());
        cuenta.Withdraw(amount);
    }
    else if (opcion == 4)
    {
        Console.WriteLine("Hasta luego!");
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }
} 