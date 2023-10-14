Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int SumElements(int n, int m)
{
  if (n == m) return n;
  else return SumElements(n + 1, m) + n;
}

int n = Prompt("Input N: ");
int m = Prompt("Input M: ");

Console.WriteLine(SumElements(n, m));