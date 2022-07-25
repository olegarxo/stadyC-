Console.Write("Число М = ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Число N = ");
int numberN = int.Parse(Console.ReadLine());
OutNaturalNumber (numberM, numberN);
void OutNaturalNumber(int numberOne, int numberTwo)
{
    if (numberOne >= numberN) return;
    else if (numberOne % 3 == 0)
    {
        Console.Write(numberOne + " ");
    }
    numberOne++;
    OutNaturalNumber(numberOne, numberN);
}