int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}

// Заполняет массив случайными цифрами
void FillingArray(int[,] array)
{
    // количество свободных ячеек
    int cellsByX = array.GetLength(1); // по Х
    int cellsByY = array.GetLength(0); // по Y
    // Переменные определяют направление
    bool isDown = true; // true - заполняет вниз, false - заполняет вверх
    bool isRight = true; // true - заполняет вправо, false - заполняет влево

    int currentNumber = 0;
    int currentX = -1;
    int currentY = 0;

    while (cellsByX != 0 || cellsByY != 0)
    {
        //// ---------------------------------------------------Движение вправо/влево--------------------------------------------------------------------////

        int startCell;
        int finishCell;

        // Если есть свободные ячейки по Y
        if (cellsByY != 0)
        {
            int currentRow = currentY;

            // Вычисление стартовой и финишной переменных
            // Если движемся вправо
            if (isRight)
            {
                finishCell = array.GetLength(1) - (array.GetLength(1) - cellsByX) / 2;
                startCell = currentX + 1;
            }
            else // Если движемся влево
            {
                finishCell = (array.GetLength(1) - cellsByX) / 2 - 1;
                startCell = currentX - 1;
            }

            // Перебор ячеек в текущей строчке, в зависимости от isRight определяются границы выполнения for
            for (int i = startCell; isRight ? i < finishCell : i > finishCell;)
            {
                array[currentRow, i] = currentNumber;
                currentNumber++;

                currentX = i;

                i = isRight ? i + 1 : i - 1;
            }

            cellsByY--;
            isRight = !isRight; // Изменение направления
        }

        //// ---------------------------------------------------Движение вверх/вниз--------------------------------------------------------------------////

        // Если есть свободные ячейки по X
        if (cellsByX != 0)
        {
            int currentColumn = currentX;

            // Вычисление стартовой и финишной переменных
            // Если движемся вниз
            if (isDown)
            {
                finishCell = array.GetLength(0) - (array.GetLength(0) - cellsByY) / 2;
                startCell = currentY + 1;
            }
            else // Если движемся вверх
            {
                finishCell = array.GetLength(0) - currentY - 1;
                startCell = currentY - 1;
            }

            // Перебор ячеек в текущей строчке, в зависимости от isDown определяются границы выполнения for
            for (int i = startCell; isDown ? i < finishCell : i > finishCell;)
            {
                array[i, currentColumn] = currentNumber;
                currentNumber++;

                currentY = i;

                i = isDown ? i + 1 : i - 1;
            }

            cellsByX--;

            isDown = !isDown; // Изменение направления
        }
    }
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write(array[i, j] + ",\t ");
        }

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}


// Метод, принимает строку, выводит в консоль
static void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Получение данных от пользователя
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

//int[,] array0 = FillSpiral(new int[m, n]);
//Output2DArray(array0, "Массив: ");

// Создание, заполнение и вывод массива
DateTime d1 = DateTime.Now;
int[,] array1 = new int[m, n];
FillingArray(array1);
//Output2DArray(array1, "Массив: ");
PrintResult(  (DateTime.Now - d1));
