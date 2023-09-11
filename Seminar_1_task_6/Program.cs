Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Check = number % 2;

if(Check == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}