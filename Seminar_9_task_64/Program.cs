Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Number(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{Number(n, m + 1)}, ");
  return m;
}

int n = Prompt("Input N: ");
if (n < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(Number(n, 1));