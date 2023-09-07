Console.WriteLine("Введите 1 число:");
int Number1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите 2 число:");
int Number2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine((Number2 % Number1==0)?true : Number2 % Number1);
