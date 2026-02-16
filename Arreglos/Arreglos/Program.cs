int[] n = new int[4];
int promedio;
int Mayorsalary;
n[0] = 100;
n[1] = 100;
n[2] = 200;
n[3] = 100;

promedio = (n[0] + n[1] + n[2] + n[3]) / 4;
Console.WriteLine("Promedio: " + promedio);

Mayorsalary = n[0];


for (int i = 1; i < n.Length; i++)
{
    if (n[i] > Mayorsalary)
    {
        Mayorsalary = n[i];
    }
}
Console.WriteLine("El sueldo que esta encima del promedio es: " + Mayorsalary);