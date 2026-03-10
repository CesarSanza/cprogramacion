namespace LieDetector;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the suspect name: ");
        string nombre = Console.ReadLine();


        Lie detector = new Lie(nombre);

        Console.Write($"Insert the suspect Aswer {nombre}: ");
        string respuesta = Console.ReadLine();

     

        detector.AnalyzeAnswer(respuesta);
        detector.ShowInfo();

        if (detector.IsLier())
            Console.WriteLine("Procced without caution.");
        else
            Console.WriteLine("The suspect is not lying.");
    }
}