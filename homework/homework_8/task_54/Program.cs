void PrintMatrix(int[,] sumMassive)
{
    int lines = sumMassive.GetLength(0);
    int columns = sumMassive.GetLength(1);
    for(int i = 0; i < lines;i++)
    {
        for(int j =0; j < columns; j++)
        {
           Console.Write($"{sumMassive[i,j]}\t");
           
        }
        Console.WriteLine();
    }
}
void EnteMatrix(int[,] sumMassive)
{
    Random random = new Random();
    int lines = sumMassive.GetLength(0);
    int columns = sumMassive.GetLength(1);
    for(int i = 0; i < lines; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            sumMassive[i,j] = random.Next(1,10);
        }
    }
}
void StreamlineMatrix(int[,] sumMassive)
{
    int tamp = 0;
    Random random = new Random();
    int lines = sumMassive.GetLength(0);
    int columns = sumMassive.GetLength(1);
    for(int i = 0; i < lines;i++)
    {
        for(int j = 0;j < columns;j++)
        {
            for(int k = 0; k < columns - 1;k++)
            {
                if(sumMassive[i, k] > sumMassive[i, k+1])
                {
                    tamp = sumMassive[i, k];
                    sumMassive[i, k] = sumMassive[i, k+1];
                    sumMassive[i, k+1] = tamp;
                }
            }
        
        }
    } 
}
Random random = new Random();
int lines = random.Next(1,10);
int columns = random.Next(1,10);
int[,] sumMatrix = new int[lines,columns];
Console.WriteLine($"Количество строк {lines}");
Console.WriteLine($"Количество Столбцов {columns}");
EnteMatrix(sumMatrix);
PrintMatrix(sumMatrix);
StreamlineMatrix(sumMatrix);
Console.WriteLine();
PrintMatrix(sumMatrix);

