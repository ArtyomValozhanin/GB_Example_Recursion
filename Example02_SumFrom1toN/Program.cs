// Сумма чисел от 1 до n

int SummFor(int n) // итеративный метод
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    // {
    //     result += i;
    // }
    return result;
}

int SummRec(int n) // рекурсивный метод
{
    if (n == 0) return 0;
    else return n + SummRec(n - 1);
}
Console.WriteLine(SummFor(10));
Console.WriteLine(SummRec(10));
