// Задача 60.
// 1.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// 2. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();
int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] +=count;
                count+=2;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {

        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write(" ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k],4} ({i}, {j}, {k})");
            }
            Console.WriteLine(" ");
        }
    }
}

    int[, ,] array3D = CreateMatrixRndInt(3, 3, 3, 10, 99);
    PrintMatrix(array3D);
    Console.WriteLine();

