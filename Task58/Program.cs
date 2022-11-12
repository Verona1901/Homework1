// Задача 58:
// 1. Задайте две матрицы.
// 2. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array2D = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("1 Матрица");
PrintMatrix(array2D);
Console.WriteLine();

int[,] array2D2 = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("2 Матрица");
PrintMatrix(array2D2);

if (array2D.GetLength(0) != array2D2.GetLength(1))
{
    Console.WriteLine(" Нельзя умножить матрицы (число столбцов 1 матрицы должно равняется числу строк 2 матрицы) ");
    return;
}
else 
Console.WriteLine("Произведение матриц 1 * 2");


int[,] array2D3 = CreateMatrixRndInt(2, 2, 1, 10);
MatrixMultiplication(array2D3);
PrintMatrix(array2D3);

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void MatrixMultiplication(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array2D3[i, j] = 0;
            for (int k = 0; k < array2D2.GetLength(1); k++)
            {
                array2D3[i, j] += array2D[i, k] * array2D2[k, j];
            }
        }

    }
}

