Console.WriteLine("Введите число в 10 системе счисления");
int numberIn10 = int.Parse(Console.ReadLine()??"0");
int numberIn2 = 0;
int count = 1;
    while (numberIn10!=0)
{
    numberIn2=numberIn2+(numberIn10%2)*count;
    count=count*10;
    numberIn10=numberIn10/2;
}
Console.WriteLine( "Число в двоичной системе счисления будет -->" + numberIn2);
