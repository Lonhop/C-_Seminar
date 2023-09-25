// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int count = Convert.ToInt32(value);

    return count;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count, int min, int max)
{
    int[] randomNumbers = new int[count];
    for (int i = 0; i < randomNumbers.Length; i++)
        randomNumbers[i] = new Random().Next(min, max);
    return randomNumbers;
}
// Создаёт копию заданного массива с помощью поэлементного копирования
int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];
    
    // перебор элементов 
    for (int i = 0; i < array.Length; i++)
        copiedArray[i] = array[i];

    return copiedArray;
}
// Выводит элементы массива в консоль
void OutputArray(string message, int[] array)
{
    Console.Write(message);
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

int count = Prompt("Введите размер массива: ");

int[] array = RandomArray(count, 0, 15);
OutputArray("Оригинальный массив: ", array);

int[] copiedArray = CopyArray(array);
OutputArray("Новый массив: ", copiedArray);