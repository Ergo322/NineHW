string Sum(int M, int N)
{
    if (M == N) return $"{N} ";
    return M + " " + Sum(M + 1, N);
}
Console.WriteLine(Sum(5, 15));