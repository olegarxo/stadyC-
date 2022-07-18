internal class Programs
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

        Random random = new Random();
        int length = random.Next(1, 11);
        int height = random.Next(1, 11);
        int[,] number = new int[height, length];
        EnterNumber(number);
        Console.WriteLine("ВВедите позицию элемента в массиви");
        Console.Write("Столбец массива: ");
        int enterLength = int.Parse(Console.ReadLine());
        Console.Write("Строка массива: ");
        int enterHeight = int.Parse(Console.ReadLine());
        if(enterLength > length || enterHeight > height || enterLength < 1 || enterHeight <1)
        {
            Console.WriteLine($"Числа с позициями {enterLength}/{enterHeight} в массиве нет");
        }
        else
        {
            Console.WriteLine($"Искомое число: {number[enterHeight-1,enterLength-1]}");
        }
        PrintMatrix(number);


    }
}