using System;

public class Person
{
    protected string name;
    protected string gender;
    protected int age;

    public Person(string newName, string newGender, int newAge)
    {
        name = newName;
        gender = newGender;
        age = newAge;
    }

    public void Salute()
    {
        Console.WriteLine($"Hi, my name is {name}, and I am {age} years old.");
    }
    
    public string GetName() { return name; }
    public string GetGender() { return gender; }
    public int GetAge() { return age; }

    public void SetName(string newName) { name = newName; }
    public void SetGender(string newGender) { gender = newGender; }
    public void SetAge(int newAge) { age = newAge; }
}

public class Student : Person
{
    private string major;
    private int currentSemester;

    public Student(string newName, string newGender, int newAge, string newMajor, int newSemester)
        : base(newName, newGender, newAge)
    {
        major = newMajor;
        currentSemester = newSemester;
    }

    public void AttendClass()
    {
        Console.WriteLine($"I am attending to a class in the {major} major.");
    }

    public void DoHomework()
    {
        Console.WriteLine("I am doing homework.");
    }

 
    public string GetMajor() { return major; }
    public int GetCurrentSemester() { return currentSemester; }

    public void SetMajor(string newMajor) { major = newMajor; }
    public void SetCurrentSemester(int newSemester) { currentSemester = newSemester; }
}

public class Professor : Person
{
    private string department;

    public Professor(string newName, string newGender, int newAge, string newDepartment)
        : base(newName, newGender, newAge)
    {
        department = newDepartment;
    }

    public void Teach()
    {
        Console.WriteLine($"I am  {name} and I am teaching {department}.");
    }

   
    public string GetDepartment() { return department; }
    public void SetDepartment(string newDepartment) { department = newDepartment; }
}

