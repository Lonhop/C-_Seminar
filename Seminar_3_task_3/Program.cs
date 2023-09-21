int topNum = TakeData("Введите целое число больше 0: "); // читаем число из консоли 

while (topNum<1){ // Проверяем корректность воода, если нет то сообщаем об этом и просим ввести корректное число
    Console.WriteLine("Число должно быть больше 0!");
    topNum = TakeData("Введите целое число больше 0: ");
}


int i=1; // счетчик для цикла
int cube=0; // куб числа
int numDigitsCube=0;  // количество цифр в кубе числа
string firstStr="\u2551 Число:    \u2551"; // первая строка таблицы с границами в виде псевдографики
string secStr="\u2551 Куб числа:\u2551"; // вторая строка таблицы с границами в виде псевдографики

while(i<=topNum){
    cube=(int)Math.Pow(i,3); // вычисляем куб числа
    numDigitsCube=(int)Math.Log10(cube) + 1; // вычисляем количество цифр в кубе числа через логарифм
    firstStr=firstStr+((i).ToString()).PadRight(numDigitsCube)+"\u2551"; // дополняем первую строку таблицы числом, необходимым количеством пробелов и границей ячейки таблицы
    secStr=secStr+cube.ToString()+"\u2551"; // дополняем вторую строку таблицы значением куба числа и границей ячейки таблицы
    i++;
}

DrawUniLine(firstStr,"\u2554","\u2566", "\u2557");
Console.WriteLine(firstStr);
DrawUniLine(firstStr,"\u2560","\u256C", "\u2563");
Console.WriteLine(secStr);
DrawUniLine(firstStr,"\u255A","\u2569", "\u255D");

int TakeData (string msg) { //метод считывающий целое число из консоли, выводя в неё сообщение
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
} 


void DrawUniLine(string sampleStr, string startSym, string midSym, string stopSym)
{
        Console.Write(startSym); //рисуем левый верхний угол таблицы
    int i=1;
    while (i<sampleStr.Length-1){
        if(sampleStr[i]=='\u2551') Console.Write(midSym); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием вниз
        else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
        i++;
    }
    Console.WriteLine(stopSym); //рисуем правый верхний угол таблицы
}