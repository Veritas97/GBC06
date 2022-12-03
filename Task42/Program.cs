Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

string NumBinary(int numA)
{
    string numB = string.Empty;
    while (numA > 0)
    {
        numB = numA % 2 + numB;
        numA /= 2;
    }

    return numB;
}

string BinaryNumber = NumBinary(numberN);
Console.WriteLine($"Ваше двоичное число: {BinaryNumber}");