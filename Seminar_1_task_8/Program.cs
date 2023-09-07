Console.WriteLine("Введите ваше число:");
int Number = Convert.ToInt32(Console.ReadLine()??"0");
int count = 0;
if (Number%2!=0)
{
    Number=Number-1;
}
while (count<Number)
{
    count = count+2;
    Console.Write(count+" ");
}
