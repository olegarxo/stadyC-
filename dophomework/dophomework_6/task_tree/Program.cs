Console.Write("Введите проверяемое число: ");
double enterNum = double.Parse(Console.ReadLine());
double num = enterNum;
while(true)
{
    if(enterNum / 3 == 1)
    {
        Console.WriteLine($"{num} является степерью числа 3");
        break;
    }
    else if (enterNum < 1)
    {
        Console.WriteLine($"{num} не является степерью числа");
        break;
    }
    enterNum = enterNum/3;
}