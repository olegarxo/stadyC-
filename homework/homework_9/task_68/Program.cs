Console.WriteLine("Дана функция Аккермана A(m,n)");
Console.Write("Введите значение переменной m = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение переменной n = ");
int n = int.Parse(Console.ReadLine());
int Akerman( int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akerman(m - 1, Akerman(m, n - 1));
    else return n + 1;
}
Console.WriteLine(Akerman(m, n));