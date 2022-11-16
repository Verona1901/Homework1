// Задача 66: 
// 1.Задайте значения M и N. 
// 2.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int num1, int num2)
{
    int summa;
    if (num2 < num1)
    {
        summa = sum(num2 - 1, num1);
    }
    else
    {
        summa = sum(num1 - 1, num2);
    }
    return summa;
}

int sum(int num1, int num2)
{
    if (num1 == num2)
    {
        return 0;
    }
    return num2 + sum(num1, num2 - 1);
}

Console.WriteLine($"Сумма элементов в промежутке от {num1} до {num2} = {SumNaturalNumbers(num1, num2)}");

