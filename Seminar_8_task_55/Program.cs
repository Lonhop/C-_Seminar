int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Распечатать массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Rotate2DArray(int[,] matrix)
{
    int buf = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1 + i; j < matrix.GetLength(1); j++)
        {
            buf = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = buf;
        }
    }
}

bool TestArrayRotate(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else return false;
}

Console.Clear();
int[,] arr2D = Fill2DArray(3, 3, 10, 1);
Print2DArray(arr2D);