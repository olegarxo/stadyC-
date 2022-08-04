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
           sumMatrix[i,j] = random.Next(0,2);
        }
    }
    sumMatrix[0,0] = 1;
    sumMatrix[4,4] = 1;
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
void FindWayFirst (int [,] sumMassive,int i = 0,int j = 0)
{   
    if(i == 4 && j == 4) return;
    i++;
    if(sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);
    else j++;
    if (sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);   
    else i--;
    if (sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);
    else
    {Console.WriteLine("Такого пути нет");
    return;
    }
}  
void FindWaySecond (int [,] sumMassive,int i,int j)
{
    if(i == 4 && j == 4)
    {
        Console.WriteLine("ПРоход есть");
        return;
    }
    i++;
    if(sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);
    else j++;
    if (sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);   
    else i--;
    if(sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);
    else j++;
    if(sumMassive[i,j] == 1) FindWaySecond(sumMassive,i,j);
    else j++;
}  
Random random = new Random();
int[,] matrix = new int[5,5];
EnterMutrix(matrix);
PrintMatrix(matrix);
FindWayFirst(matrix);
open