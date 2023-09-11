Console.WriteLine("Введите 1 число:  ");
int Number1 = Convert.ToInt32(Console.ReadLine()??"0");
Console.WriteLine("Введите 2 число:  ");
int Number2 = Convert.ToInt32(Console.ReadLine()??"0");
Console.WriteLine("Введите 3 число:  ");
int Number3 = Convert.ToInt32(Console.ReadLine()??"0");
int max = Math.Max(Number1, Math.Max(Number2, Number3));
Console.WriteLine("max = " + max );
