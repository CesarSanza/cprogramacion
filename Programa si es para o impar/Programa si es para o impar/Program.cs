int number1;
int residuo;

static void funcion(int number1)
{
    int residuo = number1 % 2;
    if (residuo == 0)
        Console.WriteLine("The number its par");
    else
        Console.WriteLine("The number its impar");
}
Console.WriteLine("Give me a number");
string input = Console.ReadLine();
number1 = int.Parse(input);

for (int i = 0; i <= 10; i++)
{
    int resultado = number1 * i;
    Console.WriteLine(number1 + " x " + i + " = " + resultado);
}
funcion(number1);