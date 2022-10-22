// Задача 38:
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);

    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMax(double[] array)
{
 double maxNumber = array[0];
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        
    }

    return maxNumber;
}

double FindMin(double[] array)
{
 double minNumber = array[0];
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
        
    }
    return minNumber;
}

double DifferenceMaxMin(double[] array)
{
    double maxNumber = FindMax(array);
    double minNumber = FindMin(array);
    double differenceMaxMin = maxNumber - minNumber;
    differenceMaxMin = Math.Round(differenceMaxMin, 2);
    Console.WriteLine ($"Максимальный элемент массива => {maxNumber}; минимальный элемент массива => {minNumber}");
    return  differenceMaxMin;
    
}
double[] arr = CreateArrayRndDouble(5, -100, 100);
PrintArrayDouble(arr);
double diff = DifferenceMaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");