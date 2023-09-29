using System.Text.RegularExpressions;
Console.Clear();

int numOfKeyPresses = ReadInt("Введите количество нажатий: ");  // Ввод пользователем количества нажатий.
string data = KeyPresses("Введите строку: ", numOfKeyPresses);  // Получение нажатий с клавиатуры.
//Console.WriteLine(data);
int count = CountPositiveNumbers(data);                         // Подсчет положительных чисел в строке.
PrintResult($"\nВведено чисел больше нуля: {count}");           // Вывод результата в консоль.

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Получение нажатий с клавиатуры.
string KeyPresses(string msg, int numOfKeyPresses)
{
    Console.Write(msg);
    string data = string.Empty;
    
    for (int i = 0; i < numOfKeyPresses; i++)
    {
        var keyInfo = Console.ReadKey();
        data += keyInfo.KeyChar;
    }

    return data;
}

// Подсчет положительных чисел в строке с использованием регулярных выражений.
int CountPositiveNumbers(string input)
{
    string pattern = @"[-]?[0-9]+";
    MatchCollection matches = Regex.Matches(input, pattern);

    int count = 0;
    foreach (Match match in matches)
    {
        if (int.Parse(match.Value) > 0) { count++; }
    }
    return count;
}

// Вывод результата в консоль.
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}