Console.Write("Введите длину массива: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRandom(int Size, int min, int max)
{
    int[] arr = new int[Size];
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }

    return copy;
}

int[] Array = CreateArrayRandom(SizeArray, 1, 10);
PrintArray(Array);
int[] ArrayCopy = CopyArray(Array);
PrintArray(ArrayCopy);