
void Varient_with_char()
{
    Console.WriteLine("Введите ваше число:");
    int number = Convert.ToInt32(Console.ReadLine()?? "0");
    // Вводим число
    string digit = Convert.ToString(number);
    // Вводим number через массив
    if (digit.Length>2)
    // Проверяем на наличие 3 цифры
    {
        Console.Write("Третья цифра в числе " + number + " Равняется " + digit[2]);
        // Выводим данное число
    }
    else
    {
        Console.Write("Третья цифра у числа отстуствует");
        // Говорим что данное число не подходит под решение
    }
}
void Varient_without()
{
    Console.WriteLine("Введите ваше число:");
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Вводим число
    double digit = Math.Log10(number);
    digit = (int)digit;
    // Делаем digit целым числом number 
    if (digit>1)
    // Проверяем условие
    {
        int count = 1;
        // Вводим count с помощью которого будем отодвигать число до 3 переменной
        int number3= number;
        // Число для цикла
        while (count<digit-1)
        // Делаем до тех пор пока 3 число не будет получено
        {
            number3=number3/10;
            // Делим число пока оно не станет 3 значным
            count++;
        }
        Console.Write("Третья цифра в числе " + number + " Равняется " + number3%10);
    }
    else
    {
        Console.Write("Третья цифра у числа отстуствует");
    }
}
//Varient_with_char();
Varient_without();