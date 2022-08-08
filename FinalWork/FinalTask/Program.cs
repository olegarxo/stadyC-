internal class Program
{
        
    static void NumberLessThree(string[] matrix, out int count)
    {
        count = 0;
        int length = matrix.Length;
        foreach (string n in matrix)
        {
            if (n.Length <= 3)
            {
                count++;
            }
        }
    }
    static void NumberLessThree(string[] matrix, string[] matrixSecond)
    {
        int length = matrix.Length;
        for(int i = 0, k = 0; i < length; i++)
        {
            if(matrix[i].Length <= 3)
            {
                matrixSecond[k] = matrix[i];
                k++;
            }
        }
    }
    static void EnterMatrix(string[] matrix)
    {
        int length = matrix.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{i+1}-я строка:");
            matrix[i] = Console.ReadLine();
        }
    }
    static void PrintMatrix(string[] matrix)
    {
        int length = matrix.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{i+1}-е слово: {matrix[i]} ");
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int countTerms = 0;
        try {
            countTerms = int.Parse(Console.ReadLine());
        }
        catch{
            Console.WriteLine("Ошибка ввода");
            return;
        }
        int countLessThree = 0;
        string[] enterNumber = new string[countTerms];
        EnterMatrix(enterNumber);
        PrintMatrix(enterNumber);
        NumberLessThree(enterNumber, out countLessThree);
        string[] OutNumber = new string[countLessThree];
        NumberLessThree(enterNumber,OutNumber);
        if(OutNumber.Length == 0)
            Console.WriteLine("Нет строк с количеством символов меньше трех");
        int tamp = 1;
        Console.WriteLine("Всего строк удовлетворяющих условию:" + OutNumber.Length);
        foreach(string n in OutNumber)
        {
            Console.Write($"{tamp}-я строка: {n} |");
            tamp++;
        }
        
    }
}
