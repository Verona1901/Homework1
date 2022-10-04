// Задача 8: Напишите программу, которая
// 1. на вход принимает число (N),
// 2. а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= number)
{
    if (counter % 2 == 0)
    Console.Write($"{counter} ");
    counter++;
}

