int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив
void FillingArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = i + j;
}
// Выводит элементы массива в консоль
void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

int[,] array = new int[m, n];
FillingArray(array, m, n);
OutputArray(array);