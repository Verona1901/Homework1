// Задача 41: 
// 1.Пользователь вводит с клавиатуры M чисел.
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите элементы массива(числа) через пробел:  ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int CountNumbersArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

PrintArray(arr);

int count = CountNumbersArray(arr);
Console.WriteLine($"Количество элементов массива > 0 => {count}");



