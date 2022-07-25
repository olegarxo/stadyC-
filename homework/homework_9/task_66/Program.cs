Console.Write("Число М = ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Число N = ");
int numberN = int.Parse(Console.ReadLine());
int sum = 0;
int count = numberN - numberM;
OutSummumber (numberM, numberN, sum);
void OutSummumber(int numberOne, int numberTwo, int sum = 0)
{
    sum += numberOne;
    numberOne++;
    if (numberOne > numberTwo) 
    {
    Console.WriteLine(sum);
    return;
    }
    OutSummumber(numberOne, numberN, sum);
}