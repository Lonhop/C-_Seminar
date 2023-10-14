Console.Clear();


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Формирование строки с числами
string SearchForNaturalElementsRec (int m, int n)
{
    return n >= m ? $"{m} " + SearchForNaturalElementsRec(m + 1, n) : "";
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

Console.WriteLine((m>n)?SearchForNaturalElementsRec(n, m):SearchForNaturalElementsRec(m, n));