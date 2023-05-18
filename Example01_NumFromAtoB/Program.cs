// Собрать строку с числами от a до b, где a <= b

string NumbersFor(int a, int b) // Итеративный подход
{
    string result = string.Empty;
    for (int i = a; i <= b; i++) // i++ инкримент; i-- декримент
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b) // Рекурсивный подход
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    // для разворота вывода, достаточно поменять местами слогаемые в условии.
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));