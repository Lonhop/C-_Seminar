Console.Clear();
int m = Numbers("Введите m: ");
int n = Numbers("Введите n: ");
int range = Numbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int MinFromSumLine = 0;
int SumFromLine = SumFromLineElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumFromLineElements(array, i);
  if (SumFromLine > tempSumLine)
  {
    SumFromLine = tempSumLine;
    MinFromSumLine = i;
  }
}
Console.WriteLine($"\n{MinFromSumLine+1} - строкa с наименьшей суммой ({SumFromLine}) элементов ");

int SumFromLineElements(int[,] array, int i)
{
  int SumFromLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    SumFromLine += array[i,j];
  }
  return SumFromLine;
}
WriteArray(array);

int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}