// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 2: Напишите программу, которая
// 1. на вход принимает два числа
// 2. и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите целое число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (number1 == number2)
{
    Console.WriteLine("Числа равны!");
}
else if (number1 > number2)
{
    max = number1;
}
else max = number2;
Console.WriteLine($"-> max  = {max}");

