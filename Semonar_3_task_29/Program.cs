//string[] Prompt(string message)
//{
   // Console.WriteLine(message);
    //string value = Console.ReadLine()??",";
    //string[] names = value.Replace(".", ",").Replace(" ", "").Split(",");

    //return names;
//}
// Выбирает случайный индекс массива
//int RandomName(int length)
//{
   // return new Random().Next(0, length);
//}

//string[] names = Prompt("Введите имена через запятую или точку: ");

//Console.WriteLine(names[RandomName(names.Length)]);
Console.WriteLine("Введите размер массива:");
int digit = int.Parse(Console.ReadLine()??"0");
// Вводим размер массива
Console.WriteLine("Введите диапозон минимального элемента:");
int MinNumber = int.Parse(Console.ReadLine()??"0");
// Вводим минимальное значение в массиве
Console.WriteLine("Введите диапозон максимального элемента:");
int MaxNumber = int.Parse(Console.ReadLine()??"0");
// Вводим максимальное значение в массиве
int[] randomArray = new int[digit];
// переменная что будем массивом
for (int i = 0; i < digit; i++)
{
randomArray[i] = new Random().Next(MinNumber,MaxNumber);
// Рандомный элемент
Console.Write("[" + randomArray[i]+"]," );
// Вывод массива
}