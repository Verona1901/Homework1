// Задача 4: Напишите программу, которая
// 1. принимает на вход три числа
// 2. и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите целое число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (number1 > number2)
{
    max = number1;
}
else if (number2 > number3)
{
    max = number2;
}
else max = number3;
Console.WriteLine($"-> max  = {max}");
