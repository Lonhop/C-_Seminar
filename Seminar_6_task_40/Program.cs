Console.WriteLine("Введите длину 1 стороны:");
int Len1 = int.Parse( Console.ReadLine()??"0");
// Вводим 1 длину треугольника
Console.WriteLine("Введите длину 2 стороны:");
int Len2 = int.Parse( Console.ReadLine()??"0");
// Вводим 2 длину треугольника
Console.WriteLine("Введите длину 3 стороны:");
int Len3 = int.Parse( Console.ReadLine()??"0");
// Вводим 3 длину треугольника
Console.WriteLine((Len1<Len2+Len3 
                && Len2<Len1+Len3 
                && Len3<Len1+Len2)?true  : "Такого треугольника не существует");
// Проверяем является ли треугольником