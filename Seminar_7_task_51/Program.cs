int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void Random2DArray(int[,] array, int minElement, int maxElement)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minElement, maxElement);
}
// Ищет элементы, у которых оба индекса чётные и меняет их
int MainDiagonalSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

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
int minElement = 0;
int maxElement = 10;

int[,] array = new int[m, n];
Random2DArray(array, minElement, maxElement);
Output2DArray(array, "Массив: ");

Console.WriteLine("Сумма эл-тов главной диагонали: " + MainDiagonalSum(array));