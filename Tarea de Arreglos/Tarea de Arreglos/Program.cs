int[]folio=new int[8];
folio[0]=10;
folio[1]=14;
folio[2]=101;
folio[3]=105;
folio[4]=801;
folio[5]=1607;
folio[6]=2034;
folio[7]=5607;
Console.WriteLine("Ingresa el numero de folio");
int numeroFolio = int.Parse(Console.ReadLine());

if (folio.Contains(numeroFolio))
{
    Console.WriteLine("Folio encontrado");
}
else
{
    Console.WriteLine("Folio no encontrado");
}
    