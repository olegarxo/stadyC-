int[] RandomLinesColums()
{
    Random random = new Random();
    int lines = random.Next(2,10);
    int colums = random.Next(2,10);
    int[] rectangle = new int[2];
    rectangle[0] = colums;
    rectangle[1] = lines;
    if (lines == colums)
    {
        RandomLinesColums();
    }
    return rectangle;
    
}
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
int MaxIndex(int[,] sumMassive)
{
    int lines = sumMassive.GetLength(0);
    int columns = sumMassive.GetLength(1);
    int maxSum = 0;
    int index = 1;
    for(int i = 0;i < lines; i++)
    {
    int sum = 0;
        for(int j = 0; j < columns; j++)
        {
        sum+=sumMassive[i,j];
        if(maxSum < sum)
        {
            maxSum = sum;
            index = i;
        }
        }

    }
    return index;
}
int[] rectangleSize = RandomLinesColums();
int[,] rectangle = new int[rectangleSize[0],rectangleSize[1]];
EnteMatrix(rectangle);
PrintMatrix(rectangle);
int index = MaxIndex(rectangle);
Console.WriteLine($"максимальная сумма элементов в {index + 1} строке.");

