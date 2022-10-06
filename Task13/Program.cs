// Задача 13: Напишите программу, которая
// 1. выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)

    Console.WriteLine("Третьей цифры нет!");
else
{
    while (number > 1000)
    {
        number /= 10;
    }
    int thirdDigit = number % 10;

    Console.WriteLine($"Третья цифра числа => {thirdDigit}");
}
