Console.Clear();



int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}




int MethodOfAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return MethodOfAkkerman(m - 1, 1);
  else return MethodOfAkkerman(m - 1, MethodOfAkkerman(m, n - 1));
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

Console.WriteLine($"A({m},{n}) = {MethodOfAkkerman(m, n)}");
