// Задача 43: Напишите программу, которая 
// 1.найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Точка пересечения двух прямых:");
PrintArray(FindCross(b1, k1, b2, k2));

double[] FindCross(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[] {x,y};
}


void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        double x = Math.Round (array[i],2);
        if (i < array.Length - 1) Console.Write($"{x}, ");
        else Console.Write($"{x} ");
    }
    Console.WriteLine(")");
}
