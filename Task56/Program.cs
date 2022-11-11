// Задача 56: 
//1. Задайте прямоугольный двумерный массив. 
// 2.Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void MinLineSum(int[,] matrix)
{
    int minSum = Int32.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumLine += matrix[i, j];
        }
        if (sumLine <= minSum)
        {
            minSum = sumLine;
            index = i;
        }
    }
    Console.WriteLine($"{index} - строкa с наименьшей суммой  элементов ({minSum}) ");
}

int[,] array2D = CreateMatrixRndInt(3, 2, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

MinLineSum(array2D);
