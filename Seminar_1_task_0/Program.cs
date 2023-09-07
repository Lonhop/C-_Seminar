Console.WriteLine("Введите число:  ");
// считываем данные с консоли
string? inputNum = Console.ReadLine();
// проверяем чтобы не был пустым
if(inputNum!=null)
{
    Console.WriteLine("Квадрат числа:"+(int)Math.Pow(int.Parse(inputNum),2));
}