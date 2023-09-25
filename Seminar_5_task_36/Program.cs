int[] array = GenArray(5, 100, 1000);
PrintArray("Исходный массив:\n", array);

//Подсчет четных чисел в массиве и вывод результата
int Count = CountNumbers(array);
PrintResult($"Количество четных элементов в массиве: {Count}");

int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

//Подсчет четных чисел в массиве
int CountNumbers(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num.Length % 2 == 0) { count++; }
    }
    return count;
}