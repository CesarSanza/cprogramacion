using System;
using System.IO;

class Examples
{
    static void Main(string[] args)
    {
        string path = "C:\\Users\\Cesar\\Desktop\\clase POO\\myfile.txt";

       
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("\"El nitrógeno presente en nuestro ADN,");
            sw.WriteLine("el calcio de nuestros dientes, el hierro de nuestra sangre,");
            sw.WriteLine("el carbono en las tartas de manzana…");
            sw.WriteLine("todos fueron creados en el interior de estrellas que chocaron entre sí.");
            sw.WriteLine("Estamos hechos del material de las estrellas.\"");
            sw.WriteLine("Carl Sagan.");
        }
        
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        
        FileInfo fileInfo = new FileInfo(path);
        Console.WriteLine($"File Name: {fileInfo.Name}");
        Console.WriteLine($"Size: {fileInfo.Length} bytes");
        Console.WriteLine($"Created: {fileInfo.CreationTime}");
    }
}