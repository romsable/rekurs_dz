
int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return akkerman(m - 1, 1);
    if (m > 0 && n > 0) return akkerman(m - 1, akkerman(m, n - 1));
    return 0;
}

Console.Write("Введите неотрицательное число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(akkerman(m, n));