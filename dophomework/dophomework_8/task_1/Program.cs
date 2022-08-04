
void PrintMatrix(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int line = matrix.GetLength(0);
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}    
void EnterMutrix(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int line = matrix.GetLength(0);
    Random random = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(1,10);
        }
    }

}
void ItemReplacement (int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int line = matrix.GetLength(0);
  
    if (columns == line)
    {
        for(int i = line - 1, k = 0;i > 0; i--, k++)
        {
            matrix[0,k] = matrix[k,k];
            matrix[line - 1,k] = matrix[i,k]; 
        }
        (matrix[0,columns - 1],matrix[line - 1,columns - 1]) = (matrix[line - 1,columns - 1],matrix[0,columns - 1]);
    }    
}
Random random = new Random();
int line = random.Next(4,5);
int colum = random.Next(4,5);
int[,] matrix = new int[line,colum];
EnterMutrix(matrix);
PrintMatrix(matrix);
ItemReplacement(matrix);
Console.WriteLine();
PrintMatrix(matrix);