Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num1==Math.Pow(num2,2)? "Да" : "Нет");
