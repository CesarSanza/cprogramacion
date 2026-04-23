namespace ShapesApp;
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Cuanto mide la base del rectángulo? ");
        int base_ = int.Parse(Console.ReadLine());

        Console.Write("Cuanto mide la altura del rectángulo? ");
        int height = int.Parse(Console.ReadLine());

        
        Console.Write("Ingresa el radio del círculo? ");
        int radius = int.Parse(Console.ReadLine());

        
        Rectangle rect   = new Rectangle(base_, height);
        Circle circle = new Circle(radius);
        
        Console.WriteLine("Área del rectángulo: " + rect.CalculateArea());
        Console.WriteLine("Área del círculo:    " + circle.CalculateArea());
    }
}
