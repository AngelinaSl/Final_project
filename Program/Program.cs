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

Console.WriteLine("Введите количество элементов массива (рекомендуем ввести не более 5ти): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5)
    Console.WriteLine("Некорректный ввод данных. Введите число, которое меньше или равно 5.");
else if (n == 0) Console.WriteLine("Некорректный ввод данных. Массив не может состоять из 0 элементов.");
else if (n < 0) Console.WriteLine("Некорректный ввод данных. Размер массива не может быть отрицательным числом. ");
else
{
    string[] firstStringArray = FillStringArray(n);
    PrintStringArray(firstStringArray);
    int size = FindSizeOfArrayRows(firstStringArray);
    if (n == 0) Console.WriteLine("[]");
    else
    {
        Console.WriteLine(" --> ");
        string[] secondStringArray = FillNewStringArray(firstStringArray, size);
        PrintStringArray(secondStringArray);
    };
}
