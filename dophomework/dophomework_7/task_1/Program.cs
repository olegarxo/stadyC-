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
           sumMatrix[i,j] = random.Next(-9,10);
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
void Multiplicationmatrix(int[,] matrixOne,int[,] matrixTwo)
{
    int fithtLine = matrixOne.GetLength(0);
    int secondColums = matrixTwo.GetLength(1);
    int[,] mainMatrix = new int[fithtLine,secondColums];
    if(fithtLine == secondColums)
    {
        for(int i = 0; i < fithtLine; i++)
        {   int k =0;
            for(int j = 0; j < secondColums; j++)
            {
                mainMatrix[i,j] = matrixOne[i,k] * matrixTwo[i,j]; 
            }
        }
        PrintMatrix(mainMatrix);
    }
    else{
    Console.WriteLine("УПС, количество строк первой матрицы не равно количеству столбцов второй");
    Console.WriteLine("Операция матричного умножения не может быть выполнена");
    }
}
Random random = new Random();
// int line = random.Next(3,5);
// int colums = random.Next(3,5);
int [,] firthtMatrix = new int[random.Next(3,5),random.Next(3,5)];
int [,] secondMatrix = new int[random.Next(3,5),random.Next(3,5)];
EnterMutrix(firthtMatrix);
EnterMutrix(secondMatrix);
PrintMatrix(firthtMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
Multiplicationmatrix(firthtMatrix,secondMatrix);