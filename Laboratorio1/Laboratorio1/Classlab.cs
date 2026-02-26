namespace Laboratorio1;

public class Classlab
{
    public string name;
    public string department;
    public float salary;

    public Classlab(string name, string department, float salary)
    {
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    public float GetSalary()
    {
        return salary;
    }
}