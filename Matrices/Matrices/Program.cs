int[,] myMatrix ={{1,2,3,4,5},{6,7,8,9,10}};
int n = 2, m = 5;
for(int i = 0; i < n; i++) 
{
    for(int j = 0; j < m; j++) 
    {
        Console.Write(myMatrix[i,j] +" ");
    }
    Console.WriteLine();
}
