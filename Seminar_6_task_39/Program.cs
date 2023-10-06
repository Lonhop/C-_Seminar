Console.Clear();
int [] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
     { 
        array[i] = rnd.Next(minValue, maxValue + 1); 
        }
    return array;
}

void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i =0;i<arr.Length;i++)
    {
        outArr[arr.Length-1 - i] = arr[i];
    }
    return outArr;
}
void SwapArray(int[] arr)
{
    int buferElement = 0;
    for(int i =0; i<arr.Length/2;i++)
    {
        (arr[arr.Length-1 - i],arr[i])=(arr[i], arr[arr.Length-1 - i]);
         buferElement = arr[arr.Length-1 - i];
         arr[arr.Length-1 - i]=arr[i];
         arr[i] = buferElement;
    }
}
int[] arr = GenerateRandomArray(15,1,100);
PrintArray("",arr);
int[] swapArr = SwapNewArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);
Console.WriteLine("Перевернутый массив");
PrintArray("",swapArr);

SwapArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);
