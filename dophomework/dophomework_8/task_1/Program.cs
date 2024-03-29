﻿
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
  
    if (columns == line || columns < line)
    {
        int i = line - 1;
        int k = 0;
        for(;i > 0; i--, k++)
        {
            matrix[0,k] = matrix[k,k];
            matrix[line - 1,k] = matrix[i,k]; 
        }
        i = line - 1;
        k = 0;
        (matrix[0,columns - 1],matrix[i,columns - 1]) = (matrix[i,columns - 1],matrix[0,columns - 1]);
    }
    else
    {
        int i = columns - 1;
        int k = 0;
        for(;i > 0; i--, k++)
        {
            matrix[0,k] = matrix[k,k];
            matrix[columns - 1,k] = matrix[i,k]; 
        }
        (matrix[0,i],matrix[i,i]) = (matrix[line - 1,i],matrix[0,i]);   
    }    
}
Random random = new Random();
int line = random.Next(4,15);
int colum = random.Next(4,12);
int[,] matrix = new int[line,colum];
EnterMutrix(matrix);
PrintMatrix(matrix);
ItemReplacement(matrix);
Console.WriteLine();
PrintMatrix(matrix);