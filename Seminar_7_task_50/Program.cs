using System.Numerics;

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void Fibonacci2DArray(BigInteger[,] array)
{
    array[0, 0] = 0;
    array[0, 1] = 1;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i == 0 ? 2 : 0; j < array.GetLength(1); j++)
            if (j == 0) array[i, j] = array[i - 1, array.GetLength(1) - 1] + array[i - 1, array.GetLength(1) - 2];
            else if (j == 1) array[i, j] = array[i, j - 1] + array[i - 1, array.GetLength(1) - 1];
            else array[i, j] = array[i, j - 1] + array[i, j - 2];
}
// Выводит элементы массива в консоль
void Output2DArray(BigInteger[,] array, string message, int[] elementPosition)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (i == elementPosition[0] && j == elementPosition[1])
                Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(array[i, j]);
            Console.ResetColor();
            Console.Write(",\t ");
        }

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

BigInteger[,] array = new BigInteger[5, 5];
int[] elementPosition = {-1, -1};
Fibonacci2DArray(array);
Output2DArray(array, "Массив: ", elementPosition);

elementPosition[0] = Prompt("Введите x (индекс первого элемента 0): ");
elementPosition[1] = Prompt("Введите y (индекс первого элемента 0): ");

if (elementPosition[0] < array.GetLength(0) && elementPosition[1] < array.GetLength(1))
    Output2DArray(array, "Массив: ", elementPosition);
else Console.WriteLine("Элемента в массиве нет.");