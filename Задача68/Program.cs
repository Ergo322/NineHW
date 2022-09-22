int Akkerman(int M, int N)
{
  if (M == 0)
    return N + 1;
  else
    if ((M != 0) && (N == 0))
      return Akkerman(M - 1, 1);
    else
      return Akkerman(M - 1, Akkerman(M, N - 1));
}
Console.WriteLine($"{Akkerman(3,2)}");