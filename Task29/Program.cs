// Задача 29: Напишите программу,
// 1. которая задаёт массив из 8 элементов
// 2. и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int num)
{
    int[] array = new int[num];
    Console.Write("[");
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
    {
        if (arr.Length > 0)                 // чтобы запятая не ставилась после последнего элемента)
        Console.Write(arr[arr.Length - 1]);  
    }
}
int[] myArr = FillArray(8);
PrintArray(myArr);
Console.Write("]");

