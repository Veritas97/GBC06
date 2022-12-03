Console.Write("Введите число первое: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число второе: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число третье: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA + numberB > numberC && 
    numberA + numberC > numberB &&
    numberB + numberC > numberA) 
    Console.WriteLine("Такой треугольник может существовать!");
else Console.WriteLine("Такой треугольник не может существовать!");