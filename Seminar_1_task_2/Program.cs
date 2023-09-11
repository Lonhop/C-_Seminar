Console.WriteLine("Введите 1 число:  ");
int Number1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите 2 число:  ");
int Number2 = int.Parse(Console.ReadLine()??"0");
int max=0;
int min=0;
if (Number1>Number2)
{
    max=Number1;
    min=Number2;
}
else
{
    max=Number2;
    min=Number1 ;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
