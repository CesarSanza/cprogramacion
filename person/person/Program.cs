class Program
{
    static void Main(string[] args)
    {
       
        Student student = new Student(
            "Miguel",
            "Male",
            34,
            "Computer Science",
            2
        );

        student.AttendClass();
        student.DoHomework();
        student.Salute();

        Console.WriteLine();

       
        Professor professor = new Professor(
            "Carlos",
            "Male",
            45,
            "Computer Science"
        );

        professor.Teach();
        professor.Salute();
    }
}