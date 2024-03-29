string NatNumbers(int n, int m)
{
    if (m == n)
    {
        return Convert.ToString(m);
    }
    return m + " " + NatNumbers(n, m + 1);
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NatNumbers(N, M));
