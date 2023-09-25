using System.Numerics;

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Считает первые N чисел Фибоначчи
BigInteger[] FibonacciNumbers(int N)
{
    BigInteger[] fibonacciArray = new BigInteger[N];
    fibonacciArray[0] = 0;
    fibonacciArray[1] = 1;

    for (int i = 2; i < N; i++)
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];

    return fibonacciArray;
}
// Выводит элементы массива в консоль
void OutputFibonacci(BigInteger[] fibonacciArray)
{
    for (int i = 0; i < fibonacciArray.Length - 1; i++)
        Console.Write(fibonacciArray[i] + ", ");
    Console.Write(fibonacciArray[fibonacciArray.Length - 1] + ".");
}

int N = Prompt("Введите N: ");

BigInteger[] fibonacciArray = FibonacciNumbers(N);
Console.Write($"Первые {N} чисел Фибоначчи: ");
OutputFibonacci(fibonacciArray);