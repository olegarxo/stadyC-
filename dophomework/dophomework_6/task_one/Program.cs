void PrintMatrix (string matrix)
{   
    int length = matrix.Length;
    for(int j =0; j < length; j++)
    {
        Console.Write(matrix[j]); 
    }
}
void ConclusionBinary(string sumString)
 {   
     List<int> sumMassive = new List<int>();
     int textTonumber = 0; 
     textTonumber = Convert.ToInt32(sumString);
     for(int i = 0;textTonumber > 0;i++)
     {
         sumMassive.Add(textTonumber % 2);
         textTonumber /= 2;
     }
     int length = sumMassive.Count;
     int j = 0;
     while(length > 0)
     {
        Console.Write($"{sumMassive[length - 1]}");
        length-=1;
        j++;
     }
 }
Console.WriteLine("Напишите десятичное число: ");
string number = Console.ReadLine();
PrintMatrix(number);
ConclusionBinary(number);
