Console.WriteLine("Введите трехзначное число:");

int number = int.Parse(Console.ReadLine()??"0");
// Вводим наше число
int digit = 0;
// Вводим число в которое будем записывать наше значение
if (99<number & number<1000)
// Проверяем является ли оно трехзначным
{
    digit = (number/10)%10;
    Console.Write(digit );
    // Выводим наше Число
}
else
{
    Console.Write("Данное число не является трехнзначным");
    // Число не подходит под задачу
}