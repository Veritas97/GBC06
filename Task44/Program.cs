Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int[] FibonachiNumber(int numb)
{
    int[] arr = new int[numb];
    arr[1] = 1;

    for (int i = 2; i < numb; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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

int[] fib = FibonachiNumber(numberN);
PrintArray(fib);
