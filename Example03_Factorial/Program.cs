// Факториал числа N

int FactorialFor(int n) // итеративный метод
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n) // рекурсивный метод
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(8));
Console.WriteLine(FactorialRec(8)); 