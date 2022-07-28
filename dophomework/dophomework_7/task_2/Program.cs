Console.Clear();
void EnterMutrix (int [,] sumMatrix)
{
    Random random = new Random();
    int line = sumMatrix.GetLength(0);
    int columns = sumMatrix.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           sumMatrix[i,j] = random.Next(100,1000);
        }
    }
}
void PrintMatrix (int [,] sumMatrix)
{
    int line = sumMatrix.GetLength(0);
    int columns = sumMatrix.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          Console.Write(sumMatrix[i,j]+"\t"); 
        }
        Console.WriteLine();
    }
}
void SumMoreСomposition(int[,] sumMatrix)
{
    int line = sumMatrix.GetLength(0);
    int columns = sumMatrix.GetLength(1);
    List<int> number = new List<int>();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            int composition = 1;
            int tamp = sumMatrix[i,j];
            while(tamp >= 1 )
            {
                sum = sum+(tamp % 10);
                composition = composition*(tamp % 10);
                tamp /= 10;
            }
            if(sum > composition)
            {
                number.Add(sumMatrix[i,j]);
            }
        }
    }
    Console.WriteLine();
    foreach(int num in number)
    {
        Console.Write(num + "\t");
    }
}
int[,] matrix = new int[3,5];
EnterMutrix(matrix);
PrintMatrix(matrix);
SumMoreСomposition(matrix);

