int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matrix[i,j]+" ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// 1 1 1       1 3 3 0,0   0,1
// 2 2 2 ->[]  2 2 2
// 3 3 3       3 1 1 matrix.GetLength(0)-1,0   matrix.GetLength(0)-1,1

void Change2DArray(int[,] matrix)
{
    int temp=0;
    for(int i=0;i<matrix.GetLength(1);i++)
    {
        temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i]=temp;
    }
}

int[,] arr2D = Fill2DArray(10,10,10,1);
Print2DArray(arr2D);

Console.WriteLine("-----------------------------------------");
Change2DArray(arr2D);

Print2DArray(arr2D);