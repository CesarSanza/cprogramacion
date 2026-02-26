using Laboratorio1;

Console.Write("¿Cuántos empleados desea ingresar? ");
int n = int.Parse(Console.ReadLine());

Classlab[] employees = new Classlab[n];

for (int i = 0; i < employees.Length; i++)
{
    Console.WriteLine($"\n--- Empleado {i + 1} ---");

    Console.Write("Nombre: ");
    string name = Console.ReadLine();

    Console.Write("Departamento: ");
    string department = Console.ReadLine();

    Console.Write("Sueldo: ");
    float salary = float.Parse(Console.ReadLine());

    employees[i] = new Classlab(name, department, salary);
}

float total = 0;
for (int i = 0; i < employees.Length; i++)
{
    total = total + employees[i].GetSalary();
}
float promedio = total / employees.Length;

Console.WriteLine($"\nEl promedio de los sueldos es: ${promedio}");

Console.WriteLine("Los siguientes empleados ganan menos del promedio:");
for (int i = 0; i < employees.Length; i++)
{
    if (employees[i].GetSalary() < promedio)
    {
        Console.WriteLine(employees[i].name);
    }
}