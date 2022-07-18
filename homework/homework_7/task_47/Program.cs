void EnterNumber (double [,] matrix)
{
    Random random = new Random();
    int length = matrix.GetLength(1);
    int height = matrix.GetLength(0);
    for(int i =0; i<height; i++)
    {
        for(int j =0; j < length; j++)
        {
            matrix[i,j] = Math.Round((random.NextDouble() * 10), 1);
        }
    }
}
void PrintMatrix (double [,] matrix)
{
    
    int length = matrix.GetLength(1);
    int height = matrix.GetLength(0);
    for(int i =0; i<height; i++)
    {
        for(int j =0; j < length; j++)
        {
                Console.Write($"{matrix[i,j]}\t"); 
        }
        Console.WriteLine();
    }
}


Random random = new Random();
int length = random.Next(1,11);
int height = random.Next(1,11);
double [,] number = new double [height,length];
EnterNumber(number);
PrintMatrix(number);

