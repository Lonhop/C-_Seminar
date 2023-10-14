Console.Clear();


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


void GenLineRec(int num)
{
    Console.Write(num+" ");
    if(num<=1)
    {
    }
    else
    {
       GenLineRec(num-1);
    }
}

int num = ReadData("Введите число N: ");
GenLineRec(num);