// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralArray(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    int i = 0;
    int j = 0;

    for (int temp = 1; temp <= matrix.GetLength(0) * matrix.GetLength(1); temp++)
    {

//Console.WriteLine(i + "  " + j + " - " + matrix.GetLength(0) + " = " + matrix.GetLength(1));
        matrix[i, j] = temp;
        
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
        //temp++;

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

    int[,] array2D = SpiralArray(3, 3, 1, 100);
    PrintMatrix(array2D);
    

        