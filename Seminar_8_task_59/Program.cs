Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10;
int maxValue = 10;
int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
PrintMatrix("Заданная матрица", matrix);

// Поиск индексов минимального элемента
(int smallestValue, int colIndex, int rowIndex) min = FindMinElement(matrix);
Console.WriteLine ($"Наименьший элемент: {min.smallestValue} позиция [{min.rowIndex},{min.colIndex}]");

// Удаление строки и столбца на пересечении элемента, который наименьший в массиве и вывод нового массива
int[,] resultMatrix = RemoveRowAndColumn(matrix, min.rowIndex, min.colIndex);
PrintMatrix("Измененная матрица", resultMatrix);

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными целыми значениями.
int[,] CreateRandomMatrix(int countRow, int countCol, int minValue, int maxValue)
{
    Random random = new Random();
    int[,] matrix = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

// Вывод двумерного массива на экран.
void PrintMatrix(string msg, int[,] matrix)
{
    Console.WriteLine("\n" + msg);

    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

// Поиск наименьшего элемента в массиве и его индекса
(int smallestValue,  int colIndex, int rowIndex) FindMinElement(int[,] matrix)
{
    int smallestValue = int.MaxValue;
    int rowIndex = -1;
    int colIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < smallestValue)
            {
                smallestValue = matrix[i, j];
                rowIndex = i;
                colIndex = j;
            }
        }
    }
    return (smallestValue, rowIndex, colIndex);
}

// Удаление строки и столбца из двумерного массива
int[,] RemoveRowAndColumn(int[,] matrix, int rowIndex, int colIndex)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] resultMatrix = new int[rowCount - 1, colCount - 1];

    for (int i = 0, newRow = 0; i < rowCount; i++)
    {
        if (i == rowIndex) continue; // Если индекс строки равен индексу минимального, его пропускаем

        for (int j = 0, newCol = 0; j < colCount; j++)
        {
            if (j == colIndex) continue; // Если индекс столбца равен индексу минимального, его пропускаем

            resultMatrix[newRow, newCol] = matrix[i, j];
            newCol++;
        }
        newRow++;
    }

    return resultMatrix;
}