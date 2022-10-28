// Задача 50. Напишите программу, которая
// 1. на вход принимает позиции элемента в двумерном массиве,
// 2. и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет



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

Console.WriteLine("Введите индекс строки :");
int indexI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца:");
int indexJ = Convert.ToInt32(Console.ReadLine());

void ElementMatrix(int[,] matrix)
{
    if (indexI < 0 || indexJ < 0)
        Console.Write("Введите значение >=0"); // было упущено. добавлена проверка при отрицательных значениях
    else if (indexI < matrix.GetLength(0) && indexJ < matrix.GetLength(1))
        Console.Write($"Значение элемента {matrix[indexI, indexJ]}");

    else Console.WriteLine($"{indexI},{indexJ} -> такого элемента в массиве нет");
}

int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);

PrintMatrix(array2D);
ElementMatrix(array2D);


