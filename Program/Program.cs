string[] FillStringArray(int arrayLength)
{
    string[] stringArray = new string[arrayLength];
    Console.WriteLine("Введите рандомные слово(а) или символы в массив: ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}
void PrintStringArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length - 1; i++)
    {
        Console.Write($"{stringArray[i]}, ");
    }
    Console.Write($"{stringArray[stringArray.Length - 1]}]");
}
int FindSizeOfArrayRows(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            size++;
        }
    }
    return size;
}
string[] FillNewStringArray(string[] array, int n)
{

    string[] newStringArray = new string[n];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newStringArray[j] = array[i];
            j++;
        }
    }
    return newStringArray;
}
