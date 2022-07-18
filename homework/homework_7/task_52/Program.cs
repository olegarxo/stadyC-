internal class Programss
{
    private static void Main(string[] args)
    {
        void EnterNumber(int[,] matrix)
        {
            Random random = new Random();
            int length = matrix.GetLength(1);
            int height = matrix.GetLength(0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
        }
        void PrintMatrix(int[,] matrix)
        {

            int length = matrix.GetLength(1);
            int height = matrix.GetLength(0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        void MidleNumber(int[,] matrix)
        {
            int length = matrix.GetLength(1);
            int height = matrix.GetLength(0);
            for(int i=0; i < length; i++)
            {
                double sum = 0;
                for(int j=0; j < height; j++)
                {
                    sum += matrix[j,i];
                }
                Console.Write($"{Math.Round(sum/height,2)}\t ");
            }
        }

        Random random = new Random();
        int length = random.Next(1, 11);
        int height = random.Next(1, 11);
        int[,] number = new int[height, length];
        EnterNumber(number);
        PrintMatrix(number);
        Console.WriteLine();
        MidleNumber(number);
    }
}