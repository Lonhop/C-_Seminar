Console.WriteLine("Введите 1 число:");
int Number1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine((Number1 % 23==0 && Number1%7==0)?true : "False" );