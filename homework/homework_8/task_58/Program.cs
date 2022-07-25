// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void SnakeMassive(int[,] samMassive)
{
    int length = samMassive.Length;
    int collums = samMassive.GetLength(1);
    int line s = samMassive.GetLength(0);
    samMassive[0,0] = 1;
    for(int move = 1, index = 0, number = 1; number < length;)
    {
        for(int i = index,j = index; i < collums - index; i++)
        {
            samMassive[j,i] = number;
            number++;
        }
        for(int i = collums - index, j = index + move; j < lines - index; j++)
        {
            samMassive[j,i] = number;
            number++;
        }
        for(int i = collums - (move+index), j = lines - (move+index); i > index; i--)
        {
            samMassive[j,i] = number;
            number++;
        }
        for(int i = index, j = lines-(move+index); j > index+move; j++)
        {
            samMassive[j,i] = number;
            number++;
        }
    }
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
int [,] matrix = new int[8,8];
SnakeMassive(matrix);
PrintMatrix(matrix);
var tamp = (6,8);
cobs