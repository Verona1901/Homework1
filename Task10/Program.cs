// Задача 10: Напишите программу, которая
// 1. принимает на вход трёхзначное число
// 2. и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondDigit = (number /10) % 10;

    Console.WriteLine($"Вторая цифра числа => {secondDigit}");
}
else System.Console.WriteLine ("Число не трехзначное!");
