// Задача 25: Напишите цикл, который 
// 1.принимает на вход два числа (A и B)
// 2. и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Pow(int numA, int numB)

{
    int res = numA;

    for (int i = 1; i < numB; i++)
    {
        res *= numA;
    }
    return res;
}
int pow = Pow(numberA, numberB);
Console.WriteLine(numberB < 0 ? "B - должно быть натуральным числом!" : $"A в степени B  => {pow}");
