int[] array = GenArray(10, 100, 999);
PrintArray("Сгенерированный массив:\n", array);

// Подсчет суммы элементов, стоящих на нечётных позициях и вывод результата
int sum = CountNumbers(array);
PrintResult($"Сумма элементов, стоящих на нечётных позициях в массиве: {sum}");


CountNumbers(array);

int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

//Подсчет нечетных элементов
int CountNumbers(int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length-1 ; i=i+2)
    {
        sum = array[i]+sum;
    }
    return sum;
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg +"[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

