int[,] myMatrix = new int[3, 10];

Console.WriteLine("Ingresa los 10 numeros");
for (int i = 0; i < 10; i++)
{
    Console.Write("Número " + (i + 1) + ": ");
    int numero = int.Parse(Console.ReadLine());
    myMatrix[0, i] = numero;
    myMatrix[1, i] = numero * numero;           
    myMatrix[2, i] = numero * numero * numero; 
}
Console.WriteLine("Matriz resultante:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(myMatrix[i, j]);
        if (j < 9)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}


