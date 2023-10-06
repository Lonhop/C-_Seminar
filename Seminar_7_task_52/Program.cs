int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void IntRandom2DArray(int[,] array, int minElement, int maxElement)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minElement, maxElement + 1);
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    // Массив с цветами консоли
    ConsoleColor[] newColors = NewColorsArray( array.GetLength(1) + array.GetLength(0) - 1);

    // Вывод элементов
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.ForegroundColor = newColors[i + j];
            Console.Write(array[i, j]);
            Console.ResetColor();
            Console.Write(", ");
        }

        Console.ForegroundColor = newColors[i + array.GetLength(1) - 1];
        Console.Write(array[i, array.GetLength(1) - 1]);
        Console.ResetColor();

        Console.Write("}\n");
    }

    Console.ResetColor();

    FindAverage(newColors, array);
}
// Рандомно задаёт цвета диагоналям
ConsoleColor[] NewColorsArray(int length)
{
    // Массив со всеми цветами консоли
    ConsoleColor[] colors = { ConsoleColor.Gray, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan,
                            ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.Blue, ConsoleColor.DarkGreen,
                            ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Green,
                            ConsoleColor.DarkYellow, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta };

    // Новый массив цветов консоли, подстроенный под количество  диагоналей 
    ConsoleColor[] newColors = new ConsoleColor[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        newColors[i] = colors[rnd.Next(0, colors.Length)];
    }

    return newColors;
}
// Ищет ср знач и передаёт его в метод печати
void FindAverage(ConsoleColor[] newColors, int[,] array)
{
    // Средние значения в диагоналях 
    double[] averageValues = new double[newColors.Length];

    for (int i = 0; i < newColors.Length; i++)
    {
        int sum = 0;
        int count = 0;

        int m = i < array.GetLength(1) ? i : array.GetLength(1) - 1;
        int n = i < array.GetLength(1) ? 0 : i - array.GetLength(1) + 1;
        while (m >= 0 && n < array.GetLength(0))
        {
            sum += array[n, m];
            count++;
            m--;
            n++;
        }

        averageValues[i] = (double)sum/count;
    }

    AverageValuesOutput(newColors, averageValues);
}
// Выводит массив со средними значениями
void AverageValuesOutput(ConsoleColor[] newColors, double[] averageValues)
{
    Console.WriteLine();
    Console.WriteLine("Средние значения:");

    for (int i = 0; i < newColors.Length - 1; i++)
    {
        Console.ForegroundColor = newColors[i];
        Console.Write(averageValues[i].ToString("0.00") + ", ");
        Console.ResetColor();
    }

    // Вывод последнего элемента
    Console.ForegroundColor = newColors[newColors.Length - 1];
    Console.Write(averageValues[newColors.Length - 1].ToString("0.00") + ".");
    Console.ResetColor();
}

// Смена параметров локализации для точки в вещественных числах
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int minElement = 0;
int maxElement = 9;

int[,] array = new int[m, n];
IntRandom2DArray(array, minElement, maxElement);
Output2DArray(array, "Массив: ");