Console.Clear();

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int SumDigitRec(int num)
{

    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitRec(num / 10);
    }

}

int number=ReadData($"Введите число: ");
System.Console.WriteLine($"Сумма всех цифр в числе {number} равна {SumDigitRec(number)}.");