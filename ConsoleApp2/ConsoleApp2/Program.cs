int variable1;
int resultado;

static void chamba(int variable1)
{ 
    int resultado = variable1 % 2;
    
    if (resultado == 0)
        Console.WriteLine("El numero es par");
    else
        Console.WriteLine("El numero es impar");
}
Console.WriteLine("Dame un numero:");
variable1 = Convert.ToInt32(Console.ReadLine());
chamba(variable1);