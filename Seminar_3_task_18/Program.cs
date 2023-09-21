int getQuarter()
{
    Console.Write("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}
string pointsIdent(int quarterNum)
{
    if (quarterNum == 1) return "Возможные значения: X > 0, Y > 0";
    if (quarterNum == 2) return "Возможные значения: X < 0, Y > 0";
    if (quarterNum == 3) return "Возможные значения: X < 0, Y < 0";
    if (quarterNum == 4) return "Возможные значения: X > 0, Y < 0";
    return "Неверное значение";
}

int quarterNum = getQuarter();
Console.WriteLine(pointsIdent(quarterNum));