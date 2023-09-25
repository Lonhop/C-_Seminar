using System.Numerics;

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Считаем цифры
BigInteger CountFact(int num)
{
    BigInteger fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int num = ReadData("Введите целое число: ");
BigInteger fact = CountFact(num);
PrintResult("Факториал числа " + num + " равен " + fact);