internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        // Вводим наше число
        int SumNumber(int numberN)
        // Функция
        {

            int counter = Convert.ToString(numberN).Length;
            // Считаем количество цифр в числе
            int advance = 0;
            // Переменная где будет запоминатся цифра числа
            int result = 0;
            // сумма наших цифр

            for (int i = 0; i < counter; i++)
            {
                advance = numberN % 10;
                // Берем Последнюю цифру
                result = result + advance;
                // Складываем наши цифры
                numberN = numberN / 10;
                // Уменьшаем число дабы цикл работал дальше
            }
            return result;
        }

        int sum = SumNumber(numberN);
        // Записываем в переменную значение нашей функции
        Console.WriteLine("Сумма цифр в числе: " + sum);
        // Наш вывод
    }
}